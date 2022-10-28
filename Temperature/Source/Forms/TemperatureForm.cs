using static Temperature.Functions;
using System;
using System.Globalization;
using AltUI.Forms;
using AltUI.Win32;
using AltUI.Controls;
using Temperature.Sources.Forms.Information;
using System.Windows.Forms;
using Temperature.Properties;
using static System.Windows.Forms.DataFormats;
using System.Drawing;

namespace Temperature
{
    public partial class TemperatureForm : DarkForm
    {
        public TemperatureForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fromText.Text.Length > 0) {
                float ValToUse = (float)Convert.ToDouble(fromText.Text);

                if (fromUnit.Text != string.Empty & toUnit.Text != string.Empty)
                {
                    switch (toUnit.Text)
                    {
                        case "Celsius":
                            result.Text = Math.Round(ConvertToCelcius(ValToUse, fromUnit.Text), 2).ToString();
                            break;

                        case "Kelvin":
                            result.Text = Math.Round(ConvertToKelvin(ValToUse, fromUnit.Text), 2).ToString();
                            break;

                        case "Fahrenheit":
                            result.Text = Math.Round(ConvertToFahrenheit(ValToUse, fromUnit.Text), 2).ToString();
                            break;

                        case "Rankine":
                            result.Text = Math.Round(ConvertToRankine(ValToUse, fromUnit.Text), 2).ToString();
                            break;

                        default:
                            result.Text = fromText.Text;
                            break;
                    }
                }
            }
        }

        private void fromText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form form1 = new AboutForm();
            form1.Text = "About " + Settings.Default.Name;
            form1.ShowDialog();
        }

        private void TemperatureForm_Load(object sender, EventArgs e)
        {
            this.Text = Settings.Default.Name + " v" + Settings.Default.Version;   
        }
    }
}