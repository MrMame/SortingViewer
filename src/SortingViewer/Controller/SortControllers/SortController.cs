using SortingViewer.Model.Data.StatisticValues;
using SortingViewer.Model.Data.SortValues;
using SortingViewer.Model.SortAlgorythm;
using SortingViewer.Views.StatisticViews;
using SortingViewer.Views.UserInput;
using SortingViewer.Views.ValueViews;
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
        SortAlgorythmThread _SortThread;

        IUserInput _UI;
        IValueView _ValueView;
        IStatisticsView _StatisticView;
        ISortAlgorythmManager _SortAlgorythmManager;
        ISortAlgorythm _SortAlgorythm;
        ISortValues _SortValues = SortValuesFactory.CreateStandardSortValues();
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

        }
        #endregion PUBLIC 



        #region UI__EVENT-HANDLER
        private void UI_SetSortAlgorythm(object sender, SetSortAlgorythmEventArgs e) {
            _SortAlgorythm = _SortAlgorythmManager.GetAlgorythm(e.SortAlgorythmName);
            _SortAlgorythm.ValueChanged += new EventHandler<ValueChangedEventArgs>(onSortAlgorythmValueChanged);
            _SortAlgorythm.SortFinish += new EventHandler<SortFinishEventArgs>(onSortAlgorythmSortFinish);
            _SortAlgorythm.NextCheckingStep += new EventHandler<NextCheckingStepEventArgs>(onNextCheckingStep);
        }
        private void UI_SetValues(object sender, SetSortValuesEventArgs e) {
            _SortValues = e.SortValues;
            _ValueView.ShowValues(_SortValues);
        }
        private void UI_StopSort(object sender, EventArgs e) {
            _SortThread.StopTheSortAlgorythm();
        }
        private void UI_StartSort(object sender, EventArgs e) {
            _SortThread = SortAlgorythmThreadFactory.CreateSortAlgorythmThread(_SortAlgorythm);
            _SortThread.ThreadStopped += SortThread_onThreadStopped;
            _SortThread.StartTheSortAlgorythm(_SortValues);
        }
        #endregion UI__EVENT-HANDLER  



        #region ISortAlgorythm___EVENT-HANDLER
        private void onNextCheckingStep(object sender, NextCheckingStepEventArgs e) {
            // Show Statistics inide view
            _StatisticValues.StepNumber = e.StepNumber;
            _StatisticView.ShowStatistics(_StatisticValues);
            // Print Bars
            _ValueView.ShowValues(e.SortValues);
        }
        private void onSortAlgorythmValueChanged(object sender, ValueChangedEventArgs e) {
            // Store the info in statistic vValues
            _StatisticValues.NumberShifts = e.NumberShifts;
            // Print View
            _ValueView.ShowValues(_SortValues);
            _SortRunningState = SortWorkerStates.Sort_Running;
        }
        private void onSortAlgorythmSortFinish(object sender, SortFinishEventArgs e) {
            // Print View
            _ValueView.ShowValues(_SortValues);
            _SortRunningState = SortWorkerStates.Sort_Finished;
        }
        #endregion
        #region SortThread___EVENT-HANLDER
        private void SortThread_onThreadStopped(object sender, EventArgs e) {
            _SortRunningState = SortWorkerStates.Sort_Stopped;
        }
        #endregion



       



    }
}
