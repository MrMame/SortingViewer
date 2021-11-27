using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    class SortAlgorythmFactory {
        public static BinarySort CreateBinarySort() {
            BinarySort bs = new BinarySort();
            return bs;
        }

        public static BubbleSort CreateBubbleSort() {
            BubbleSort bs = new BubbleSort();
            bs.StepDelayTime = 20;
            return bs;
        }


    }
}
