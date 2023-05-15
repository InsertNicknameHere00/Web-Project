using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebBrowser
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LoginLinkLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string filename = NicknameBox.Text;
            StreamWriter sw =File.AppendText("C:\\Users\\Rosen\\source\\repos\\WebBrowser\\" + filename + ".txt");
            try
            {
                sw.WriteLine(NicknameBox.Text);
                sw.WriteLine(NameBox.Text);
                sw.WriteLine(PasswordBox.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exiting will result in data loss!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }