using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltUI.Forms;
using AltUI.Win32;
using AltUI.Controls;
using Temperature.Properties;

namespace Temperature.Sources.Forms.Information
{
    public partial class AboutForm : DarkForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label2.Text = "By " + Settings.Default.Author;
        }
    }
}
