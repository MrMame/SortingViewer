using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    class SortAlgorythmThread {

        //public event EventHandler<ValueChangedEventArgs> ValueChanged;
        //public event EventHandler<SortFinishEventArgs> SortFinish;
        public event EventHandler ThreadStopped;

        //object _WorkParameter = null;
        Thread _Thread;
        ISortAlgorythm _SortAlgorythm;

        public SortAlgorythmThread(ISortAlgorythm SortAlgorythm) {
            _Thread = new Thread(new ParameterizedThreadStart(DoTheWork));
            _SortAlgorythm = SortAlgorythm;
            //_SortAlgorythm.ValueChanged += SortAlgorythm_onValueChangedEvent;
            //_SortAlgorythm.SortFinish += SortAlgorythm_onSortFinishEvent;

        }

        public void StartTheSortAlgorythm(ISortValues sortValues) {
            _Thread.Start(sortValues);
        }
        public void StopTheSortAlgorythm() {
            _Thread.Abort();
        }


        private void DoTheWork(object sortValues) {
            _SortAlgorythm.DoSort((ISortValues)sortValues);
            if(ThreadStopped != null) ThreadStopped(this, null);
        }

        //private void SortAlgorythm_onValueChangedEvent(object sender , ValueChangedEventArgs e) {
        //    if(ValueChanged != null) ValueChanged(this, e);
        //}
        //private void SortAlgorythm_onSortFinishEvent(object sender, SortFinishEventArgs e ) {
        //    if(SortFinish != null) SortFinish(this, e);
        //}

    }
}
