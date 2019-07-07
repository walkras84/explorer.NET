using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explorer.NET //!explorer.NET
{
    public partial class Form1 : Form //Klasy
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e) //!Przycisk "Cofnij"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //!Przycisk "Do Przodu"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //!Przycisk "Stop"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            webBrowser1.Stop();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //!Przycisk "Odśwież"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            webBrowser1.Refresh();
        }
        
        private void toolStripButton5_Click(object sender, EventArgs e) //!Przycisk "Idź"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            webBrowser1.Navigate(toolStripTextBox1.Text); 
        }

        private void toolStripButton6_Click(object sender, EventArgs e) //!Przycisk "Drukuj"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            webBrowser1.ShowPageSetupDialog();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e) //!Wyświetla Progress bar - postęp ładowania strony
        {
            try //!Pobiera wartość Progressbar i konwertuje tą wartość do typu Int
            {
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message); - !okomentowano ponieważ generuje błedy pop-up
            }

        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e) //!Przechodzi pod podany adres internetowy po naciśnieciu przycisku "Enter", odczytuje czy został wciśniety klawisz.
        {
        if (e.KeyCode == Keys.Enter) //jeżeli klawisz który został wciśniety jest Enter-em wtedy zostaje wykonana instrukcja przejscia pod adres strony internetowej wprowadzonej do textbox
                {
                    webBrowser1.Navigate(toolStripTextBox1.Text);
                }
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog(); //!Przycisk "Zapisz"; kontrolka wykonuje akcje po kliknięciu na przycisk
        }

        private void toolStripButton8_Click(object sender, EventArgs e) //!Przycisk zakładek "Ulubione"; kontrolka wykonuje akcje po kliknięciu na przycisk
        {
            Form2 fav = new Form2();
            fav.toolStripTextBox1.Text = webBrowser1.Url.ToString();
            fav.StartPosition = FormStartPosition.CenterParent;
            fav.Show();
        }

    }
}
