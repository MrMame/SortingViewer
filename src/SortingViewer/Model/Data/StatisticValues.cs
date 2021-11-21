using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data {
    class StatisticValues : IStatisticValues {
        int _StepNumber = 0;
        public int StepNumber { get => _StepNumber; set => _StepNumber = value; }

        public override string ToString() {
            return ($"Step Number: {this._StepNumber.ToString()}");
        }
        
    }
}
