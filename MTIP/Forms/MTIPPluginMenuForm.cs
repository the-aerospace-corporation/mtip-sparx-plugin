/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Form launched from EA menu
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MTIP.Translations;

namespace MTIP.Forms
{
    public partial class MTIPPluginMenuForm : Form
    {
        private MTIP plugin;
        private MTIPExportFunctions mtipExportFunctions;
        public MTIPPluginMenuForm(MTIP plugin)
        {
            this.plugin = plugin;
            this.mtipExportFunctions = new MTIPExportFunctions(plugin);

            InitializeComponent();
        }
        private void ImportMTIP(object sender, EventArgs ea)
        {
            MTIPImportForm mtipImportForm = new MTIPImportForm(this, null, plugin, this);
            mtipImportForm.Show();
        }
        private void ExportMTIP(object sender, EventArgs ea)
        {
            mtipExportFunctions.ExportToMTIPXML();
        }

    }
}
