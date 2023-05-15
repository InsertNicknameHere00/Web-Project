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
using System.Diagnostics;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
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
            DialogResult dialogResult =  MessageBox.Show("Are you sure you wanna exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = Browser.DocumentTitle;
            HistoryBox.Text+=(Environment.NewLine + SearchBox.Text + " " + Browser.Url);
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchEngineBox.Text == "Bing")
            {
                Browser.Navigate("www.bing.com/search?q=" + SearchBox.Text);
            }
            if (SearchEngineBox.Text == "Google")
            {
                Browser.Navigate("www.google.com/search?q=" + SearchBox.Text);
            }

        }

        private void GoHomeButton_Click(object sender, EventArgs e)
        {
            if (SearchEngineBox.Text == "Bing")
            {
                Browser.Navigate("www.bing.com");
            }
            if (SearchEngineBox.Text == "Google")
            {
                Browser.Navigate("www.google.com");
            }
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            if (SearchEngineBox.Text == "Bing")
            {
                Browser.Navigate("www.bing.com");
            }
            if (SearchEngineBox.Text == "Google")
            {
                Browser.Navigate("www.google.com");
            }
            tabPage.Text = Browser.DocumentTitle;
            Browser.DocumentCompleted += Browser_DocumentCompleted;
            SearchEngineBox.SelectedIndex =1;
        }

        private void AddTabButton_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = Browser.DocumentTitle;
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            Browser = new System.Windows.Forms.WebBrowser() { ScriptErrorsSuppressed = true };
            Browser.Parent = tab;
            Browser.Dock = DockStyle.Fill;
            if (SearchEngineBox.Text == "Bing")
            {
                Browser.Navigate("www.bing.com");
            }
            if (SearchEngineBox.Text == "Google")
            {
                Browser.Navigate("www.google.com");
            }
            Browser.DocumentCompleted += Browser_DocumentCompleted;
        }

        private void RemoveTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void SaveBookmarksButton_Click(object sender, EventArgs e)
        {
            string filename = NicknameBox.Text;
            string path = ("C:\\Users\\Rosen\\source\\repos\\WebBrowser\\" + filename + ".txt");
            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText("C:\\Users\\Rosen\\source\\repos\\WebBrowser\\" + filename + "_bookmarks.txt");
                try
                {
                    sw.WriteLine(Browser.Url);
                    sw.WriteLine();
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
            else
            {
                MessageBox.Show("Missing Profile!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookmarksButton_Click(object sender, EventArgs e)
        {
            string filename = NicknameBox.Text;
            string path = ("C:\\Users\\Rosen\\source\\repos\\WebBrowser\\" + filename + ".txt");
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader("C:\\Users\\Rosen\\source\\repos\\WebBrowser\\" + filename + "_bookmarks.txt");
                try
                {
                    string fileContents = sr.ReadToEnd();
                    BookmarksBox.Text = fileContents;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                }
            }
            else
            {
                MessageBox.Show("Missing Profile!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookmarksBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Browser.Navigate(BookmarksBox.SelectedText);
        }

        private void HistoryBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Browser.Navigate(HistoryBox.SelectedText);
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryBox.Text = "";
        }

        private void DeleteBookmarksButton_Click(object sender, EventArgs e)
        {
            string filename = NicknameBox.Text;
            string path = ("C:\\Users\\Rosen\\source\\repos\\WebBrowser\\" + filename + "_bookmarks.txt");
            if (File.Exists(path))
            {
                File.Delete(path);
                BookmarksBox.Text = " ";
            }
            else
            {
                MessageBox.Show("Missing Bookmarks!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }