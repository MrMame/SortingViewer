using SortingViewer.Model.Data;
using SortingViewer.View.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class ValueView_DebugPrintMock : IValueView {
        public void ResetView() {
            throw new NotImplementedException();
        }

        public void ShowValues(ISortValues Values) {
            throw new NotImplementedException();
        }
    }
}
