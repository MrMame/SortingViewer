using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using SortingViewer.View.Statistic;
using SortingViewer.View.UserInput;
using SortingViewer.View.Value;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller
{
    public class SortController{

        public enum SortWorkerStates {
            Sort_Running,
            Sort_Finished,
            Sort_Stopped,
            Sort_Ready
        }

        public SortWorkerStates SortProcessState { get => _SortRunningState; }
        public IStatisticValues StatisticValues { get => _StatisticValues; }
        public ISortValues SortValues { get => _SortValues; }

        SortWorkerStates _SortRunningState = SortWorkerStates.Sort_Ready;
        BackgroundWorker _SortWorker;

        IUserInput _UI;
        IValueView _ValueView;
        IStatisticsView _StatisticView;
        ISortAlgorythmManager _SortAlgorythmManager;
        ISortAlgorythm _SortAlgorythm;
        ISortValues _SortValues;
        IStatisticValues _StatisticValues;

        #region PUBLIC
        public SortController(IUserInput UI, IValueView ValueView, IStatisticsView StatisticView, ISortAlgorythmManager SortAlgorythmManager) {
            if(UI == null || ValueView == null || StatisticView == null || SortAlgorythmManager == null) throw new ArgumentNullException();

            _UI = UI;
            _ValueView = ValueView;
            _StatisticView = StatisticView;
            _SortAlgorythmManager = SortAlgorythmManager;

            _StatisticValues = new StatisticValues();

            _UI.StartSort += UI_StartSort;
            _UI.StopSort += UI_StopSort;
            _UI.SetValues += UI_SetValues;
            _UI.SetSortAlgorythm += UI_SetSortAlgorythm;
            _UI.LoadSortAlgorythmNames(SortAlgorythmManager.GetSortAlgorythmsNames().ToArray());

            _SortWorker = new BackgroundWorker();
            _SortWorker.WorkerReportsProgress = true;
            _SortWorker.WorkerSupportsCancellation = true;
            _SortWorker.DoWork += _SortWorker_DoWork;
            _SortWorker.RunWorkerCompleted += _SortWorker_RunWorkerCompleted;
            _SortWorker.ProgressChanged += _SortWorker_ProgressChanged;

        }
        #endregion PUBLIC 



        #region SORTWORKER__EVENT-HANDLER 
        private void _SortWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            throw new NotImplementedException();
        }

        private void _SortWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this._SortRunningState = SortWorkerStates.Sort_Finished;
        }

        private void _SortWorker_DoWork(object sender, DoWorkEventArgs e) {
            _SortRunningState = SortWorkerStates.Sort_Running;

            BackgroundWorker worker = sender as BackgroundWorker;
            SortWorkerArguments workerArgs = (SortWorkerArguments)e.Argument;

            //workerArgs.SortAlgoryth.SetValues(workerArgs.SortValues);
            workerArgs.SortAlgoryth.DoSort(workerArgs.SortValues);
        }
        #endregion SORTWORKER__EVENT-HANDLER   



        #region UI__EVENT-HANDLER
        private void UI_SetSortAlgorythm(object sender, SetSortAlgorythmEventArgs e) {
            _SortAlgorythm = _SortAlgorythmManager.GetAlgorythm(e.SortAlgorythmName);
            // SortAlgorythm Events fror inform the controller about its progress
            _SortAlgorythm.ValueChanged += new EventHandler<ValueChangedEventArgs>(onSortAlgorythmValueChanged);
            _SortAlgorythm.SortFinish += new EventHandler<SortFinishEventArgs>(onSortAlgorythmSortFinish);
        }
        private void UI_SetValues(object sender, SetSortValuesEventArgs e) {
            _SortValues = e.SortValues;
            _ValueView.ShowValues(_SortValues);
        }
        private void UI_StopSort(object sender, EventArgs e) {
            if(_SortWorker.WorkerSupportsCancellation == true) {
                // Cancel the asynchronous operation.
                _SortWorker.CancelAsync();
            }
        }
        private void UI_StartSort(object sender, EventArgs e) {
            SortWorkerArguments wArgs = new SortWorkerArguments(_SortValues, _SortAlgorythm);
            _SortWorker.RunWorkerAsync(wArgs);
        }
        #endregion UI__EVENT-HANDLER  



        #region ISortAlgorythm___EVENT-HANDLER
        private void onSortAlgorythmValueChanged(object sender, ValueChangedEventArgs e) {
            _StatisticValues.StepNumber = e.StepNumber;
            _StatisticValues.NumberShifts = e.NumberShifts;
            _StatisticView.ShowStatistics(_StatisticValues);
            _ValueView.ShowValues(_SortValues);
        }
        private void onSortAlgorythmSortFinish(object sender, SortFinishEventArgs e) {
            _StatisticView.ShowStatistics(_StatisticValues);
            _ValueView.ShowValues(_SortValues);
        }
        #endregion



        #region PRIVATE
        private class SortWorkerArguments {
            public ISortValues SortValues { get => _SortValues; }
            public ISortAlgorythm SortAlgoryth { get => _SortAlgorythm; }
            
            ISortValues _SortValues;
            ISortAlgorythm _SortAlgorythm;
                
            public SortWorkerArguments(ISortValues SortValues,ISortAlgorythm SortAlgorythm) {
                _SortValues = SortValues;
                _SortAlgorythm = SortAlgorythm;
            }
        }

        #endregion PRIVATE 



    }
}
