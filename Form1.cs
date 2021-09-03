using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhantomRebels
{
    public partial class Form1 : Form
    {
        string strBaseFolder = "";
        string strBaseNormalFolder = @"%USERPROFILE%\Documents\My Games\Rising Storm 2 EGS\ROGame";
        string strBaseSteamFolder = @"%USERPROFILE%\Documents\My Games\Rising Storm 2\ROGame";
        string strResetCache = "";
        string strFixBrowser = "";
        string strReset = "";
        // Create the ToolTip and associate with the Form container.
        ToolTip toolTip1 = new ToolTip();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnResetCache_Click(object sender, EventArgs e)
        {
            var strProcessFolder = $"{strBaseFolder}\\Cache\\";
            //strFixBrowser = $"Attempts to make all servers visible again!\n\nDeletes ROEngine.ini under {strBaseFolder}\\Config\\";
            // strReset = $"Deletes the folder and all files under {strBaseFolder}";

            var result = MessageBox.Show($"You are about to delete all files in '{strProcessFolder}', are you sure ?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Do Stuff
                if (Directory.Exists(strProcessFolder))
                {
                    File.Delete($"{strProcessFolder}\\*.*");
                }
            }
        }

        private void btnFixBrowser_Click(object sender, EventArgs e)
        {
            var strProcessFolder = $"{strBaseFolder}\\Config\\";
            var result = MessageBox.Show($"You are about to delete the file 'ROEngine.ini' in '{strProcessFolder}', are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Do Stuff
                if (Directory.Exists(strProcessFolder))
                {
                    File.Delete($"{strProcessFolder}\\ROEngine.ini");
                }
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            var strProcessFolder = $"{strBaseFolder}";
            var result = MessageBox.Show($"You are about to delete all files in '{strProcessFolder}', are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Do Stuff
                if (Directory.Exists(strProcessFolder))
                {
                    File.Delete($"{strProcessFolder}\\*.*");
                }
            }
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            strBaseFolder = strBaseNormalFolder;
            strResetCache = $"This fixes out-of-sync content messages when playing on servers with custom Maps and Mutators\n\nResets Map & Mutator cache under {strBaseFolder}\\Cache\\";
            strFixBrowser = $"Attempts to make all servers visible again!\n\nDeletes ROEngine.ini under {strBaseFolder}\\Config\\";
            strReset = $"Deletes the folder and all files under {strBaseFolder}";
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnResetCache, strResetCache);
            toolTip1.SetToolTip(this.btnFixBrowser, strFixBrowser);
            toolTip1.SetToolTip(this.btnRevert, strReset);
        }

        private void radSteam_CheckedChanged(object sender, EventArgs e)
        {
            strBaseFolder = strBaseSteamFolder;
            strResetCache = $"This fixes out-of-sync content messages when playing on servers with custom Maps and Mutators\n\nResets Map & Mutator cache under {strBaseFolder}\\Cache\\";
            strFixBrowser = $"Attempts to make all servers visible again!Deletes ROEngine.ini under {strBaseFolder}\\Config\\";
            strReset = $"Deletes the folder and all files under {strBaseFolder}";
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnResetCache, strResetCache);
            toolTip1.SetToolTip(this.btnFixBrowser, strFixBrowser);
            toolTip1.SetToolTip(this.btnRevert, strReset);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            linkLabel2.Links.Add(18, 24, "mailto:MadMax@PhantomRebels.com");
            linkLabel2.LinkVisited = true;
            linkLabel1.Links.Add(7, 18, "https://PhantomRebels.com");
            linkLabel1.LinkVisited = true;

            radNormal_CheckedChanged(sender, e);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel2.Links[0].LinkData.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Links[0].LinkData.ToString());
        }
    }
}
