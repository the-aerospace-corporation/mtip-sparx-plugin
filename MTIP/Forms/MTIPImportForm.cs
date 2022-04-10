/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Form launched when "Import Huddle XML" option is clicked in MTIPMenuForm
 * 
 */

using MTIP.Translations;
using MTIP.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTIP.Forms
{
    public partial class MTIPImportForm : Form
    {
        // GUI Elements
        private MTIP plugin;
        private MTIPPluginMenuForm menuForm;
        private MTIPImportFunctions importFunctions;


        // Variables
        private List<string> selected_file_list = new List<string>();

        public MTIPImportForm(object sender, EventArgs e, MTIP plugin, MTIPPluginMenuForm menuForm)
        {
            InitializeComponent();
            this.plugin = plugin;
            this.menuForm = menuForm;
            this.importFunctions = new MTIPImportFunctions(plugin, selected_file_list);
        }

        private void Import(object sender, EventArgs e)
        {
            if (this.selected_file_list.Any())
            {
                importFunctions.StartMTIPImport();
                MessageBox.Show("XML import is complete.", "Import Complete", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You must select an XML file");
            }

            this.Close();
        }

        // Prompt users to select HUDS XML files for models to import
        private void SelectInputXml(object sender, EventArgs e)
        {
            string[] mtipFiles = Tools.PromptForFiles("Select HUDS XML file");
            if (mtipFiles != null)
            {
                foreach (string mtipFile in mtipFiles)
                {
                    string[] path_directories = mtipFile.Split(Path.DirectorySeparatorChar);
                    string display_name = path_directories[path_directories.Length - 1];

                    // add file to listbox
                    this.selectedFiles.BeginUpdate();
                    this.selectedFiles.Items.Add(display_name);
                    this.selectedFiles.EndUpdate();

                    this.selected_file_list.Add(mtipFile);

                    importButton.Enabled = true;
                }

            }
        }
    }
}
