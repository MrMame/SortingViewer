using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    public class ValueChangedEventArgs:EventArgs {
        public int StepNumber { get; set; }
        public int NumberShifts { get; set; }
    }
}
