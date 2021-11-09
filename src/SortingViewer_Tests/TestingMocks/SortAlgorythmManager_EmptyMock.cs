using SortingViewer.Controller;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class SortAlgorythmManager_EmptyMock : ISortAlgorythmManager {
        public void AddAlgorythm(string UniqueName, ISortAlgorythm SortAlgorythm) {
        }

        public ISortAlgorythm GetAlgorythm(string SortAlgorythmName) {
            return null;
        }

        public List<string> GetSortAlgorythmsNames() {
            return null;
        }
    }
}
