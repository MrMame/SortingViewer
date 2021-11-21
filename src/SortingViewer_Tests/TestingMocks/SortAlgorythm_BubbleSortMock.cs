using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm
{

    public class SortAlgorythm_BubbleSortMock : ISortAlgorythm {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

     
        public void DoSort(ISortValues Values) {
            int nSteps = 0;
            int nShifts = 0;
            for(int n = Values.Values.Length; n > 1; --n) {
                for(int i = 0; i < n - 1; ++i) {
                    if(Values.Values[i] > Values.Values[i + 1]) {
                        int tmp = Values.Values[i + 1];
                        Values.Values[i + 1] = Values.Values[i];
                        Values.Values[i] = tmp;
                        nShifts++;
                        if(ValueChanged != null) ValueChanged(this, new ValueChangedEventArgs() { StepNumber = nSteps, NumberShifts = nShifts });
                    } // Ende if
                    nSteps++;
                } // Ende innere for-Schleife
            } // Ende äußere for-Schleife
            // Fire Finish Event
            if(SortFinish != null) SortFinish(this, new SortFinishEventArgs() { TotalSteps = nSteps, NumberShifts = nShifts });
        }


        #region PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE 
            
        #endregion

    }
}
