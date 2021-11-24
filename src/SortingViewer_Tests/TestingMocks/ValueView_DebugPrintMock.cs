using NUnit.Framework;
using SortingViewer.Model.Data.SortValues;
using SortingViewer.Views.ValueViews;
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
            TestContext.WriteLine(string.Join(";",Values.Values));
        }
    }
}
