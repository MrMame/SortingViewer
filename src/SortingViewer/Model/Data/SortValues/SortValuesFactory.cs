using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data.SortValues {
    class SortValuesFactory {
        public static SortValues CreateStandardSortValues(params int[] SortValues) {
            SortValues sv = new SortValues(SortValues);
            return sv;
        }
    }
}
