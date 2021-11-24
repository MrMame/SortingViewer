using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data.StatisticValues {
    class StatisticValues : IStatisticValues {
        int _StepNumber = 0;
        int _NumberShifts = 0;
        public int StepNumber { get => _StepNumber; set => _StepNumber = value; }
        int IStatisticValues.NumberShifts { get => _NumberShifts; set => _NumberShifts=value; }


        public override string ToString() {
            return ($"Step Number: {this._StepNumber.ToString()}, NumberShifts: {this._NumberShifts.ToString()}");
        }
        
    }
}
