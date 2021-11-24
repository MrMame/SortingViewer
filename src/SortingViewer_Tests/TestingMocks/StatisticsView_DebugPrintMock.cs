using NUnit.Framework;
using SortingViewer.Model.Data.StatisticValues;
using SortingViewer.Views.StatisticViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class StatisticsView_DebugPrintMock : IStatisticsView {
        public void ResetView() {
            TestContext.WriteLine("IStatisticsView.ResetView() has Reset the Statistics.");
        }

        public void ShowStatistics(IStatisticValues Stats) {
            TestContext.WriteLine($"{DateTime.Now.ToString()} - {Stats.ToString()}");
        }
    }
}
