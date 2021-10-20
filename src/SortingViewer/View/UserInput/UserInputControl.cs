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
    public partial class UserInputControl : UserControl,iUserInput {




        public UserInputControl() {
            InitializeComponent();
        }

  

        public event EventHandler StartSort;
        public event EventHandler StopSort;
        public event EventHandler<SetSortValuesEventArgs> SetValues;
        public event EventHandler<SetSortAlgorythmEventArgs> SetSortAlgorythm;



        #region PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS -- PUBLICS
        public void LoadSortAlgorythmNames(string[] SortAlgoNames) {
            this.cmbSelectSortAlgorythm.Items.AddRange(SortAlgoNames);
            if(this.cmbSelectSortAlgorythm.Items.Count > 0) this.cmbSelectSortAlgorythm.SelectedIndex = 0;
        }
        #endregion



        #region EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS -- EVENTS
        private void btnStartSort_Click(object sender, EventArgs e) {
            if(StartSort != null) StartSort(this, e);
        }
        private void btnStopSort_Click(object sender, EventArgs e) {
            if(StopSort != null) StopSort(this, e);
        }
        private void btnSetValues_Click(object sender, EventArgs e) {
            SetSortValuesEventArgs ea = new SetSortValuesEventArgs() { SortValues = new SortValues(new int[] { 1, 2, 3, 4 }) };
            if(SetValues != null) SetValues(this,ea);
        }
        private void cmbSelectSortAlgorythm_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            SetSortAlgorythmEventArgs ea = new SetSortAlgorythmEventArgs() { SortAlgorythmName = cb.Text };
            if(SetSortAlgorythm != null) SetSortAlgorythm(this, ea);
        }
        #endregion EVENTS


    }
}
