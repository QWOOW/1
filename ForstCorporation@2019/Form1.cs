using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;

/*
 * Size: 355, 237
 * Style: Red
 * Theme: Light
 */

namespace ForstCorporation_2019
{
    public partial class Form1 : Form
    {
        bool login;
        bool usergroup;

        [Obsolete]
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            metroCheckBox1.Checked = true;

            var steam = "steam";
            var starget = Process.GetProcessesByName(steam).FirstOrDefault();

            metroTextBox1.Text = Properties.Settings.Default.Login;
            metroTextBox2.Text = Properties.Settings.Default.Password;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            login = true;

            Properties.Settings.Default.Login = metroTextBox1.Text;
            Properties.Settings.Default.Password = metroTextBox2.Text;
            Properties.Settings.Default.Cheackbox = metroCheckBox1.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
        // 355, 218

        