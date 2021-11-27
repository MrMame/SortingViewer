using SortingViewer.Model.Data.SortValues;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    /// <summary>
    /// Implements an endless running sort algorythm that generates a value cahnged event each 100ms
    /// </summary>
    class SortAlgorythm_EndlessMock : ISortAlgorythm {
        public int StepDelayTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

        public void DoSort(ISortValues Values) {
            int nShifts = 0;
            int nSteps = 0;

            while(true) {
                // only value changed events are generated.
                Thread.Sleep(100);
                nShifts++;
                if(ValueChanged != null) ValueChanged(this, new ValueChangedEventArgs() { StepNumber = nSteps, NumberShifts = nShifts });

            };
        }
    }
}
