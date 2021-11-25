using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    class SortAlgorythmThreadFactory {
        public static SortAlgorythmThread CreateSortAlgorythmThread(ISortAlgorythm sortAlgorythm) {
            return new SortAlgorythmThread(sortAlgorythm);
        }
    }
}
