using NUnit.Framework;
using SortingViewer.Model.Data;
using SortingViewer.View.Statistic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class StatisticsViewDebugPrintMock : IStatisticsView {
        public void ResetView() {
            TestContext.WriteLine("IStatisticsView.ResetView() has Reset the Statistics.");
        }

        public void ShowStatistics(IStatisticValues Stats) {
            TestContext.WriteLine(Stats.ToString());
        }
    }
}
