using SortingViewer.Model.Data.SortValues;
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
        public event EventHandler<NextCheckingStepEventArgs> NextCheckingStep;

        public int StepDelayTime { get => _StepDelayTime; set => _StepDelayTime = Math.Abs(value); }

        int _StepDelayTime=50;

        public void DoSort(ISortValues SortValues) {
            int nSteps = 0;
            int nShifts = 0;
            for(int n = SortValues.Values.Length; n > 1; --n) {
                for(int i = 0; i < n - 1; ++i) {
                    // INfo for drawing the Stepmarker
                    SortValues.LastCheckedIndx = i + 1;
                    if(NextCheckingStep != null) NextCheckingStep(this, new NextCheckingStepEventArgs() { SortValues = SortValues , StepNumber = nSteps });
                    // 
                    if(SortValues.Values[i] > SortValues.Values[i + 1]) {
                        int tmp = SortValues.Values[i + 1];
                        SortValues.Values[i + 1] = SortValues.Values[i];
                        SortValues.Values[i] = tmp;
                        // now comes the non-sort-algorythm stuff 
                        nShifts++;
                        SortValues.OldIndxOfLastShift = i;
                        SortValues.NewIndxOfLastShift = i + 1;
                        if(ValueChanged != null) ValueChanged(this, new ValueChangedEventArgs() { StepNumber = nSteps, NumberShifts = nShifts });
                    } // Ende if
                    nSteps++;
                    Thread.Sleep(_StepDelayTime);
                } // Ende innere for-Schleife
            } // Ende äußere for-Schleife
            // Fire Finish Event
            if(SortFinish != null) SortFinish(this, new SortFinishEventArgs() { TotalSteps = nSteps, NumberShifts = nShifts });
        }


        #region PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE PRIVATE 
            
        #endregion

    }
}
