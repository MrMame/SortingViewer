using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Resize(object sender, EventArgs e) {
            Random r = new Random();
            SortValues sr = new SortValues(r.Next(1, 100), r.Next(1, 100), r.Next(1, 100), r.Next(1, 100), r.Next(1, 100));
            this.valuesBarView1.ShowValues(sr);
        }
    }
}
