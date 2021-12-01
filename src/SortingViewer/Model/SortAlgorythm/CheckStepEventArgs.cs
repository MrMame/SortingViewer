using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    public class CheckStepEventArgs:EventArgs {
        public int CheckedIndex { get; set; }
        public int CheckedWithIndex { get; set; }

    }
}
