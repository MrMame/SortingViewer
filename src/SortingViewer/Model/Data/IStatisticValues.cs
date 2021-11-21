using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data {
    public interface IStatisticValues {
        string ToString();
        int StepNumber { get; set; }
        int NumberShifts { get; set; }

    }
}
