using SortingViewer.Controller;
using SortingViewer.Controller.SortAlgorythmManagers;
using SortingViewer.Controller.SortControllers;
using SortingViewer.Model.Data;
using SortingViewer.View.Statistic;
using SortingViewer.View.UserInput;
using SortingViewer.View.Value;
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


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Create Views
            IStatisticsView txtView = StatisticsViewFactory.CreateTextView();
            IValueView valBview = ValueViewFactory.CreateValueBarView();
            IUserInput uiControl = UserInputFactory.CreateUserInputView();
            
            // Add Views to the Parentcontrols
            this.splitContainer2.Panel1.Controls.Add((Control)txtView);
            this.splitContainer2.Panel2.Controls.Add((Control)uiControl);
            this.splitContainer1.Panel2.Controls.Add((Control)valBview);

            _sc = SortControllerFactory.CreateSortControllerWithPreloadedSortAlgorythms(uiControl, valBview, txtView);
            
        }

       
    }
}
