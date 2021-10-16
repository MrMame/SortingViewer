using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller {
    class SortAlgorythmManager : ISortAlgorythmManager {

        Dictionary<String,ISortAlgorythm> _SortAlgos = new System.Collections.Generic.Dictionary<String, ISortAlgorythm>();


        public SortAlgorythmManager() {
          

        }

    }
}
