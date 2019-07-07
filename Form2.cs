using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explorer.NET //!Ulubione
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        
        private void toolStripButton1_Click(object sender, EventArgs e) //!Przycisk dodający stronę www do zakładek "Ulubione"
        {
            ListViewItem item = new ListViewItem(toolStripTextBox1.Text);
            listView1.Items.Add(toolStripTextBox1.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //!Przycisk usuwający stronę www z zakładek "Ulubione"
        {
            try
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("Wybierz obiekt");
            }
        }
        
        private void Form2_Load(object sender, EventArgs e) 
        {
            System.Xml.XmlDocument loadDoc = new System.Xml.XmlDocument();
            loadDoc.Load(Application.StartupPath + "\\Zakladki.xml");
            foreach (System.Xml.XmlNode favNode in loadDoc.SelectNodes("/Zakladki/Obiekt"))
            {
                listView1.Items.Add(favNode.Attributes["url"].InnerText);
            }
        }
        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(Application.StartupPath + "\\Zakladki.xml", null);
            writer.WriteStartElement("Zakladki");
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                writer.WriteStartElement("Obiekt");
                writer.WriteAttributeString("url", listView1.Items[i].Text);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }
    }
}
