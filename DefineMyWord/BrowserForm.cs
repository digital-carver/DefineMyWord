/*
    Copyright (c) 2010 SundaraRaman Ramalingam

    This file is part of DefineMyWord.

    DefineMyWord is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    DefineMyWord is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with DefineMyWord.  If not, see <http://www.gnu.org/licenses/>.
 
*/

using System;
using System.Text;
using System.Windows.Forms;

namespace DefineMyWord
{
    public partial class BrowserForm : Form
    {
        MyUtils.KeyboardHook hotKeyHook = new MyUtils.KeyboardHook();

        public BrowserForm()
        {
            InitializeComponent();

            // Register a callback function to be called when the hotkey is pressed
            hotKeyHook.KeyPressed += new EventHandler<MyUtils.KeyPressedEventArgs>(hotKeyHook_KeyPressed);
            hotKeyHook.RegisterHotKey(MyUtils.ModifierKeys.Control | MyUtils.ModifierKeys.Alt, Keys.D);
        }

        void hotKeyHook_KeyPressed(object sender, MyUtils.KeyPressedEventArgs e)
        {
            restoreMe();

            String wordToDefine = getWordToDefine();
            String definitionUrl = getWiktionaryUrl(wordToDefine);
            goToUrl(definitionUrl);
        }

        private string getWordToDefine()
        {
            String wordToDefine = "";
            IDataObject clipboardObj = Clipboard.GetDataObject();

            if (!clipboardObj.GetDataPresent(DataFormats.Text))
            {
                while (wordToDefine.Length == 0)
                {
                    wordToDefine = Microsoft.VisualBasic.Interaction.InputBox("Please enter the word whose definition you want: ", "DefineMyWord input", "", this.Left + this.Width / 2, this.Top + this.Height / 2);
                }
            }
            else
            {
                wordToDefine = clipboardObj.GetData(DataFormats.Text).ToString();
            }
            return wordToDefine.Trim();
        }

        private string getWiktionaryUrl(string wordToDefine)
        {
            wordToDefine = System.Web.HttpUtility.UrlEncode(wordToDefine, Encoding.UTF8).ToLower();
            return "http://en.wiktionary.org/wiki/" + wordToDefine;
        }

        public void goButton_Click(object sender, EventArgs e)
        {
            goToUrl(addressBar.Text);
        }

        public void addressBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            goToUrl(addressBar.Text);
        }

        public void addressBar_GotFocus(Object sender, EventArgs e)
        {
            definitionBrowser.Stop();
        }

        // Misleadingly named, should be goToUrlOrDefineWord. That's obviously too long though. :)
        private void goToUrl(String url)
        {
            // If it contains no '.', it's probably not a URL, so assume user wants that word defined
            if (! url.Contains("."))
            {
                url = getWiktionaryUrl(url);
            }
            definitionBrowser.Url = new System.Uri(url);
            addressBar.Text = url;
        }

        private void adjustControls()
        {
            definitionBrowser.Width = Width - 15;
            definitionBrowser.Height = Height - addressBar.Height - 65;
            addressBar.Width = Width - goButton.Width - 35;
            goButton.Left = addressBar.Width + 5;
        }

        public void sysTrayNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            restoreMe();
        }

        public void BrowserForm_Load(object sender, EventArgs e)
        {
            //Start the application minimized
            minimizeMe();
        }

        public void BrowserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.TaskManagerClosing && e.CloseReason != CloseReason.WindowsShutDown)
            {
                e.Cancel = true;
                minimizeMe();
            }
        }

        public void restoreMenuItem_Click(object sender, EventArgs e)
        {
            restoreMe();
        }

        private void restoreMe()
        {
            Show();
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = true;
        }

        public void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniButton_Click(object sender, EventArgs e)
        {
            minimizeMe();
        }

        private void minimizeMe()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Hide();
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToUrl(addressBar.Text);
            }
        }


        private void BrowserForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                ShowInTaskbar = false;
            }
            else if(FormWindowState.Maximized == WindowState)
            {
                adjustControls();
            }
        }

        private void definitionBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Change the addressbar text even if we're navigating through user-clicks on the page
            addressBar.Text = e.Url.ToString();
        }

        private void BrowserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                minimizeMe();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.D && e.Alt)
            {
                addressBar.Focus();
                e.Handled = true;
            }
        }
    }
}
