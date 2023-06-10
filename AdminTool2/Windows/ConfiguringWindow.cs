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

namespace AdminTool2
{
    public partial class ConfiguringWindow : Form
    {

        public static string configFilePath = "..\\..\\Resourses\\config.cfg";
        private string[] configLines = File.ReadAllLines(configFilePath);

        public ConfiguringWindow()
        {
            InitializeComponent();

            textBox_T_MM.Text = configLines[0];
            textBox_EB_MM.Text = configLines[1];
            textBox_T_C.Text = configLines[2];
            textBox_EB_C.Text = configLines[3];
            textBox_T_K.Text = configLines[4];
            textBox_EB_K.Text = configLines[5];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            configLines[0] = textBox_T_MM.Text;
            configLines[1] = textBox_EB_MM.Text;
            configLines[2] = textBox_T_C.Text;
            configLines[3] = textBox_EB_C.Text;
            configLines[4] = textBox_T_K.Text;
            configLines[5] = textBox_EB_K.Text;

            if (!isNumbers()) MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                File.WriteAllLines(configFilePath, configLines);
                this.Close();
            }

        }

        private bool isNumbers()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    try
                    {
                        Convert.ToInt32(control.Text);
                    }
                    catch (FormatException)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
