using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.View.UserInput
{
    public interface IUserInput
    {
        void StartSort();
        void StopSort();
        void SetSortValues(ISortValues Values);
        void SetSortAlgorythm(ISortAlgorythm SortAlgorythm);

    }
}
