using SortingViewer.Model.Data.StatisticValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.View.Statistic
{
    public interface IStatisticsView
    {
        void ShowStatistics(IStatisticValues Stats);
        void ResetView();
    }
}
