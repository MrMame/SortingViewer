using SortingViewer.Controller;
using SortingViewer.Model.Data;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingViewer.View.UserInput {
    public partial class UserInputControl : UserControl,IUserInput {


        IUserInput _uiController;
        ISortAlgorythmManager _SortAlgoManager;


        public UserInputControl() {
            InitializeComponent();
        }

        public void SetUserInputController(IUserInput Controller) {
            _uiController = Controller;
        }
        public void SetSortAlgorythmManager(ISortAlgorythmManager Manager) {
            _SortAlgoManager = Manager;
            LoadSortAlgorythmnamesToCombobox(_SortAlgoManager);
        }
        
        #region IUSerInput Interface
        public void SetSortAlgorythm(ISortAlgorythm SortAlgorythm) {
            _uiController.SetSortAlgorythm(SortAlgorythm);
        }

        public void SetSortValues(ISortValues Values) {
            _uiController.SetSortValues(Values);
        }

        public void StartSort() {
            _uiController.SetSortAlgorythm(_SortAlgoManager.GetAlgorythm(cmbSelectSortAlgorythm.Text));
            _uiController.StartSort();
        }

        public void StopSort() {
            _uiController.StopSort();
        }

        #endregion



        #region EVENTS
        private void btnStartSort_Click(object sender, EventArgs e) {
            StartSort();
        }
        private void btnStopSort_Click(object sender, EventArgs e) {
            StopSort();
        }
        #endregion


        private void LoadSortAlgorythmnamesToCombobox(ISortAlgorythmManager Manager) {
            this.cmbSelectSortAlgorythm.Items.AddRange(_SortAlgoManager.GetSortAlgorythmsNames().ToArray());
        }
    }
}
