using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deleteDubl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            List<string> idsend = new List<string>(File.ReadAllLines(openFileDialog1.FileName));
            List<string> rez = new List<string>();
            //List<string> ids = new List<string>();
            //foreach (var item in idsend)
            // {
            //     ids.Add(item.Split(';')[0]);
            // }
            rez = idsend.Distinct().ToList();
            File.WriteAllLines("rez_"+rez.Count.ToString()+".txt",rez);

        }

       
        }
        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
