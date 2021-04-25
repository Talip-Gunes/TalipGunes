using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TalipGunes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        
            MessageBox.Show("deneme");

            XmlDocument i = new XmlDocument();
        DataSet ds = new DataSet();
        string url = "https://www.aa.com.tr/tr/rss/default?cat=guncel";
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
