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



        public UserInputControl() {
            InitializeComponent();
        }

        #region IUSerInput Interface
        public void SetSortAlgorythm(ISortAlgorythm SortAlgorythm) {
            throw new NotImplementedException();
        }

        public void SetSortValues(ISortValues Values) {
            throw new NotImplementedException();
        }

        public void StartSort() {
            throw new NotImplementedException();
        }

        public void StopSort() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
