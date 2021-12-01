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
            bs.StepDelayTime = 100;
            return bs;
        }

        public static ShakerSort CreateShakerSort() {
            ShakerSort ss = new ShakerSort();
            ss.StepDelayTime = 100;
            return ss;
        }

    }
}
