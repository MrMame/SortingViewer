using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    public class SortFinishEventArgs : EventArgs {
        public int TotalSteps{get; set;}
    }
}
