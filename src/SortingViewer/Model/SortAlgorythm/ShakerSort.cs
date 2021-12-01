using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    public class ShakerSort : ISortAlgorythm {
        public int StepDelayTime { get => _StepDelayTime; set => _StepDelayTime = value; }

        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;
        public event EventHandler<NextCheckingStepEventArgs> NextCheckingStep;

        int _nSteps;
        int _nShifts;
        bool _hasChanged;
        int _StepDelayTime=10;
        


        public void DoSort(ISortValues Values) {

            _nSteps = 0;
            _nShifts = 0;

            int upperThresh = Values.Values.Count();
            int lowerThresh = 1;
            int i;
            do {
                _hasChanged = false;

                for(i = lowerThresh; i <= upperThresh - 1; i++) {
                    if(Values.Values[i - 1] > Values.Values[i]) {
                        ShiftValuesIndices(Values, oldIdx: i - 1, newIdx: i);
                        DoShiftInfo();}
                    DoNextCheckingStepInfo(Values, LastCheckedIndex:i);
                    _nSteps++;
                }
                upperThresh--;

                for(i = upperThresh-1;i>= lowerThresh; i--) {
                    if(Values.Values[i - 1] > Values.Values[i]) {
                        ShiftValuesIndices(Values, oldIdx: i, newIdx: i-1);
                        DoShiftInfo();}
                    DoNextCheckingStepInfo(Values, LastCheckedIndex:i-1);
                    _nSteps++;
                }
                lowerThresh++;
            
            } while(_hasChanged);

            if(SortFinish != null) SortFinish(this, new SortFinishEventArgs() { TotalSteps = _nSteps, NumberShifts = _nShifts });

        }

      
        private void DoNextCheckingStepInfo(ISortValues SortValues, int LastCheckedIndex) {
            SortValues.LastCheckedIndx = LastCheckedIndex;
            if(NextCheckingStep != null) NextCheckingStep(this, new NextCheckingStepEventArgs() { SortValues = SortValues, StepNumber = _nSteps });
            Thread.Sleep(_StepDelayTime);
        }
        private void DoShiftInfo() {
            _hasChanged = true;
            _nShifts++;
            if(ValueChanged != null) ValueChanged(this, new ValueChangedEventArgs() { StepNumber = _nSteps, NumberShifts = _nShifts });
        }

        private void ShiftValuesIndices(ISortValues Values, int oldIdx, int newIdx) {
            int tmp = Values.Values[oldIdx];
            Values.Values[oldIdx] = Values.Values[newIdx];
            Values.Values[newIdx] = tmp;
            Values.NewIndxOfLastShift = newIdx;
            Values.OldIndxOfLastShift = oldIdx;
        }
    }
}
