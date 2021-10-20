using SortingViewer.Controller;
using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
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

        ISortAlgorythmManager _SortAlgoManager = new SortAlgorythmManager();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {


        }

        private void MainForm_Resize(object sender, EventArgs e) {
            Random r = new Random();
            SortValues sr = new SortValues(r.Next(1, 100), r.Next(1, 100), r.Next(1, 100), r.Next(1, 100), r.Next(1, 100));
            this.valuesBarView1.ShowValues(sr);
        }

       
    }
}
