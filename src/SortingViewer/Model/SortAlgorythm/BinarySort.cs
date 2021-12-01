using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm
{
    class BinarySort : ISortAlgorythm {
        public int StepDelayTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;
        public event EventHandler<NextCheckingStepEventArgs> NextCheckingStep;

        public void DoSort(ISortValues Values) {
            throw new NotImplementedException();
        }

    }
}
