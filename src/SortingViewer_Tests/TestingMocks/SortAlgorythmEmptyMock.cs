using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    public class SortAlgorythmEmptyMock : ISortAlgorythm {
        public SortAlgorythmEmptyMock() {
        }

        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

        public void DoSort() {
            throw new NotImplementedException();
        }

        public void DoSortStep() {
            throw new NotImplementedException();
        }

        public void SetValues(ISortValues Values) {
            throw new NotImplementedException();
        }
    }
}
