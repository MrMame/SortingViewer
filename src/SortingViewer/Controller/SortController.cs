using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using SortingViewer.View.Statistic;
using SortingViewer.View.UserInput;
using SortingViewer.View.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller
{
    public class SortController{
        public SortController(IUserInput UI, IValueView ValueView, IStatisticsView StatisticView) {
            if(UI == null || ValueView == null || StatisticView == null) throw new ArgumentNullException();
        }

    }
}
