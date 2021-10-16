using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller {
    public interface ISortAlgorythmManager {
        List<String> GetSortAlgorythmsNames();
        ISortAlgorythm GetAlgorythm(string SortAlgorythmName);
    }
}
