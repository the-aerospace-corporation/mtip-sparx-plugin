/*
 * Copyright 2020 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Modified template code to create plugin, menu items, and menu item functions.
 * 
 * Note: Code has been modified from template provided by Bellekins.
 * 
 */

using MTIP.Forms;
using System;
using System.Windows.Forms;

namespace MTIP
{
    public class MTIP

    {
        // define menu constants
        const string menuHeader = "-&MTIP";
        const string menuMTIPLaunch = "&Launch";
        const string menuMTIPHelp = "&Help";

        // remember if we have to say hello or goodbye
        private EA.Repository repository;

        ///
        /// Called Before EA starts to check Add-In Exists
        /// Nothing is done here.
        /// This operation needs to exists for the addin to work
        ///
        /// <param name="Repository" />the EA repository
        /// a string
        public String EA_Connect(EA.Repository Repository)
        {
            //No special processing required.
            this.repository = Repository;
            return "a string";
        }

        ///
        /// Called when user Clicks Add-Ins Menu item from within EA.
        /// Populates the Menu with our desired selections.
        /// Location can be "TreeView" "MainMenu" or "Diagram".
        ///
        /// <param name="Repository" />the repository
        /// <param name="Location" />the location of the menu
        /// <param name="MenuName" />the name of the menu
        ///
        public object EA_GetMenuItems(EA.Repository Repository, string Location, string MenuName)
        {

            switch (MenuName)
            {
                // defines the top level menu option
                case "":
                    return menuHeader;
                // defines the submenu options
                case menuHeader:
                    string[] subMenus = { menuMTIPLaunch, menuMTIPHelp };
                    return subMenus;
            }

            return "";
        }

        ///
        /// returns true if a project is currently opened
        ///
        /// <param name="Repository" />the repository
        /// true if a project is opened in EA
        bool IsProjectOpen(EA.Repository Repository)
        {
            try
            {
                EA.Collection c = Repository.Models;
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///
        /// Called once Menu has been opened to see what menu items should active.
        ///
        /// <param name="Repository" />the repository
        /// <param name="Location" />the location of the menu
        /// <param name="MenuName" />the name of the menu
        /// <param name="ItemName" />the name of the menu item
        /// <param name="IsEnabled" />boolean indicating whethe the menu item is enabled
        /// <param name="IsChecked" />boolean indicating whether the menu is checked
        public void EA_GetMenuState(EA.Repository Repository, string Location, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked)
        {
            if (IsProjectOpen(Repository))
            {
                switch (ItemName)
                {
                    // define the state of the hello menu option
                    case menuMTIPLaunch:
                        break;
                    // define the state of the goodbye menu option
                    case menuMTIPHelp:
                        break;
                    // there shouldn't be any other, but just in case disable it.
                    default:
                        IsEnabled = false;
                        break;
                }
            }
            else
            {
                // If no open project, disable all menu options
                IsEnabled = false;
            }
        }

        ///
        /// Called when user makes a selection in the menu.
        /// This is your main exit point to the rest of your Add-in
        ///
        /// <param name="Repository" />the repository
        /// <param name="Location" />the location of the menu
        /// <param name="MenuName" />the name of the menu
        /// <param name="ItemName" />the name of the selected menu item
        public void EA_MenuClick(EA.Repository Repository, string Location, string MenuName, string ItemName)
        {
            switch (ItemName)
            {
                case menuMTIPLaunch:
                    try
                    {
                        Application.Run(new MTIPPluginMenuForm(this));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Exception while running MTIP plugin: " + e.Message);
                        MessageBox.Show("   stacktrace: " + e.StackTrace);
                    }
                    break;
                case menuMTIPHelp:
                    MessageBox.Show("Coming soon");
                    break;
            }
        }

        // Get entire EA model repository
        public EA.Repository GetRepository()
        {
            return this.repository;
        }
        ///
        /// EA calls this operation when it exists. Can be used to do some cleanup work.
        ///
        public void EA_Disconnect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

    }
}