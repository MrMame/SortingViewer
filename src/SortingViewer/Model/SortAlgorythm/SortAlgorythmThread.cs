using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingViewer.Model.SortAlgorythm {
    class SortAlgorythmThread {

        public event EventHandler ThreadStopped;

        Thread _Thread;
        ISortAlgorythm _SortAlgorythm;

        public SortAlgorythmThread(ISortAlgorythm SortAlgorythm) {
            _Thread = new Thread(new ParameterizedThreadStart(DoTheWork));
            _SortAlgorythm = SortAlgorythm;
        }

        public void StartTheSortAlgorythm(ISortValues sortValues) {
            _Thread.Start(sortValues);
        }
        public void StopTheSortAlgorythm() {
            _Thread.Abort();
            if(ThreadStopped != null) ThreadStopped(this, null);
        }


        private void DoTheWork(object sortValues) {
            _SortAlgorythm.DoSort((ISortValues)sortValues);
            
        }

    }
}
