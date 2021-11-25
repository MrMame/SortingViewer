using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm
{
    public interface ISortAlgorythm
    {

        event EventHandler <ValueChangedEventArgs> ValueChanged;
        event EventHandler <SortFinishEventArgs> SortFinish;

        int StepDelayTime { get; set; }
        void DoSort(ISortValues Values);

    }
}
