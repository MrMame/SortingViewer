using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm
{

    public class BubbleSort : ISortAlgorythm {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

        //ISortValues _SortValues = new SortValues();

        public void DoSort(ISortValues SortValues) {
            int nSteps = 0;
            int nShifts = 0;
            for(int n = SortValues.Values.Length; n > 1; --n) {
                for(int i = 0; i < n - 1; ++i) {
                    if(SortValues.Values[i] > SortValues.Values[i + 1]) {
                        int tmp = SortValues.Values[i + 1];
                        SortValues.Values[i + 1] = SortValues.Values[i];
                        SortValues.Values[i] = tmp;
                        nShifts++;
                        if(ValueChanged != null) ValueChanged(this, new ValueChangedEventArgs() { StepNumber = nSteps, NumberShifts = nShifts });
                        Thread.Sleep(100);
                    } // Ende if
                    nSteps++;
                } // Ende innere for-Schleife
            } // Ende äußere for-Schleife
            // Fire Finish Event
            if(SortFinish != null) SortFinish(this, new SortFinishEventArgs() { TotalSteps = nSteps, NumberShifts = nShifts });
        }

        //public void DoSortStep() {
        //    throw new NotImplementedException();
        //}

        //public void SetValues(ISortValues Values) {
        //    _SortValues = Values;
        //}


        #region PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE 
            
        #endregion

    }
}
