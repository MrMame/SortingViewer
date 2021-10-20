using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller
{
    public interface iSortControllerUserInterface
    {
        void StartSort();
        void StopSort();
        void SetSortValues(ISortValues Values);
        void SelectSortAlgorythm(string SortAlgoName);
    }
}
