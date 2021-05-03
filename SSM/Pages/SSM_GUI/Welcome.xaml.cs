﻿using ModernWpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;


//Thoe code on this page controls the items that show up in the LIstView
namespace SSM.Pages.SSM_GUI
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        public Welcome()
        {
            InitializeComponent();

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "//Servers//"))
            {
                string[] Servers = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "//Servers//");

                for (int i = 0; i <= Servers.Length - 1; i++) // Checks each directory found for an SSM.ini file
                { if (File.Exists(Servers[i] + "//SSM.ini")) { ListView.Items.Add(System.IO.Path.GetFileName(Servers[i])); } }
            }

            if (ListView.Items.Contains("Easter Egg")) { ((MainWindow)System.Windows.Application.Current.MainWindow).Title += "Genki Zenkai DAY DAY DAY!"; }//Special thanks to seth for this one 
            else { ((MainWindow)System.Windows.Application.Current.MainWindow).Title = "SSM Next"; }
        }

        private void ServerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {   //If clicked sends them to server manager ( unless its the new server option )
            string SelectedValue = ListView.SelectedValue.ToString();
            SelectedValue = SelectedValue.Replace("ModernWpf.Controls.ListViewItem: ","");
            if (SelectedValue == "Create a new server") {((MainWindow)System.Windows.Application.Current.MainWindow).UserDisplay.Content = new NewServer(); }
            else if (SelectedValue == "Create new server (Automatic)") {((MainWindow)System.Windows.Application.Current.MainWindow).UserDisplay.Content = new NewServer(); }
            else {LoadPage();} //Calls the function to start to load the game
        }
        
        private void LoadPage()
        {
            string SelectedValue = ListView.SelectedValue.ToString();
            SelectedValue = SelectedValue.Replace("ModernWpf.Controls.ListViewItem: ", "");
            SSMGeneric.Read_INI_File(SelectedValue);
            switch (ServerInfo.ServerGame) //This sends the user to the correct page
            {
                case "Minecraft Java": ((MainWindow)System.Windows.Application.Current.MainWindow).UserDisplay.Content = new ServerManager() ; break;

                case "Minecraft Bedrock": ((MainWindow)System.Windows.Application.Current.MainWindow).UserDisplay.Content = new ServerManager(); break;

                case "Terraria": ((MainWindow)System.Windows.Application.Current.MainWindow).UserDisplay.Content = new ServerManager(); break;
            }
        }
             
    
    }
}