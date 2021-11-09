using SortingViewer.Model.Data;
using SortingViewer.View.UserInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class UserInput_Mock : IUserInput {
        public event EventHandler StartSort;
        public event EventHandler StopSort;
        public event EventHandler<SetSortValuesEventArgs> SetValues;
        public event EventHandler<SetSortAlgorythmEventArgs> SetSortAlgorythm;


        public void LoadSortAlgorythmNames(string[] SortAlgoNames) {
        }

        public void Do_StartSort() {
            if(StartSort != null) StartSort(this, null);
        }
        public void Do_StopSort() {
            if(StopSort != null) StopSort(this, null);
        }
        public void Do_SetValues(ISortValues Values) {
            if(SetValues != null) SetValues(this, new SetSortValuesEventArgs() { SortValues = Values});
        }
        public void Do_SetSortAlgorythm(string SortAlgoName) {
            if(SetSortAlgorythm != null) SetSortAlgorythm(this, new SetSortAlgorythmEventArgs() { SortAlgorythmName = SortAlgoName });
        }

    }
}
