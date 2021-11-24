using SortingViewer.Model.Data.StatisticValues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingViewer.View.Statistic {
    public partial class StatisticsTextView : UserControl,IStatisticsView {
        public StatisticsTextView() {
            InitializeComponent();
        }

        public void ResetView() {
            txtOutput.Clear();
        }

        public void ShowStatistics(IStatisticValues Stats) {
            if(txtOutput.InvokeRequired) {
                Action safeWrite = delegate { ShowStatistics(Stats); };
                this.Invoke(safeWrite);
            } else { 
                txtOutput.AppendText($"{DateTime.Now.ToString()} - nSteps:{Stats.StepNumber.ToString()}, nShifts:{Stats.NumberShifts.ToString()}" + "\r\n");
            }
        }
    }
}
