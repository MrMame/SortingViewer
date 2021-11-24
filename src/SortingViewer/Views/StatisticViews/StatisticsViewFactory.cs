using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SortingViewer.Views.StatisticViews {
    public class StatisticsViewFactory {
        /// <summary>
        /// Creates a Text Statistics View inside the Parentcontrol
        /// </summary>
        /// <param name="ParentControl">Control that will include the new Statisticsview</param>
        /// <returns></returns>
        public static StatisticsTextView CreateTextView() {
            StatisticsTextView tView = new StatisticsTextView();
            tView.Dock = DockStyle.Fill;
            return tView;
        }
    }
}
