using SortingViewer.Controller;
using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using SortingViewer.View.Statistic;
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

        SortController _sc;
        ISortAlgorythmManager _SortAlgoManager = new SortAlgorythmManager();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Create Views
            IStatisticsView txtView = StatisticsViewFactory.CreateTextView();
            
            // Add Views to the Parentcontrols
            this.splitContainer2.Panel1.Controls.Add((Control)txtView);

            _SortAlgoManager.AddAlgorythm("BubbleSort", new BubbleSort());
            _sc = new SortController(this.userInputControl1, this.valuesBarView1, txtView, _SortAlgoManager);
        }

       
    }
}
