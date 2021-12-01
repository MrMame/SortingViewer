using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    public class NextCheckingStepEventArgs :EventArgs{
        public ISortValues SortValues { get; set; }
        public int StepNumber { get; internal set; }
    }
}
