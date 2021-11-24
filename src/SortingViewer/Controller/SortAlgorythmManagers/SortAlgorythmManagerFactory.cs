using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller.SortAlgorythmManagers {
    class SortAlgorythmManagerFactory {
        public static SortAlgorythmManager CreatePreloadedManager() {
            SortAlgorythmManager sam = new SortAlgorythmManager();
            sam.AddAlgorythm("BubbleSort", SortAlgorythmFactory.CreateBubbleSort());
            sam.AddAlgorythm("BinarySort", SortAlgorythmFactory.CreateBinarySort());
            return sam;
        }

    }
}
