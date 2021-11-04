using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm
{
<<<<<<< HEAD
    class BubbleSort : ISortAlgorythm {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

        public void DoSort() {
            throw new NotImplementedException();
=======
    public class BubbleSort : ISortAlgorythm {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

        ISortValues _SortValues = new SortValues();

        public void DoSort() {
            int nSteps = 0;
            for(int n = _SortValues.Values.Length; n > 1; --n) {
                for(int i = 0; i < n - 1; ++i) {
                    if(_SortValues.Values[i] > _SortValues.Values[i + 1]) {
                        int tmp = _SortValues.Values[i + 1];
                        _SortValues.Values[i + 1] = _SortValues.Values[i];
                        _SortValues.Values[i] = tmp;
                        if(ValueChanged != null) ValueChanged(this, new ValueChangedEventArgs() { StepNumber = nSteps });
                    } // Ende if
                    nSteps++;
                } // Ende innere for-Schleife
            } // Ende äußere for-Schleife
            // Fire Finish Event
            if(SortFinish != null) SortFinish(this, new SortFinishEventArgs() { TotalSteps = nSteps});
>>>>>>> Implementing_ISortAlgorythm
        }

        public void DoSortStep() {
            throw new NotImplementedException();
        }

        public void SetValues(ISortValues Values) {
<<<<<<< HEAD
            throw new NotImplementedException();
        }
=======
            _SortValues = Values;
        }


        #region PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE 
            
        #endregion


>>>>>>> Implementing_ISortAlgorythm
    }
}
