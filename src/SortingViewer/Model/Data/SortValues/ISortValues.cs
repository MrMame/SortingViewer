using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data.SortValues
{
    public interface ISortValues
    {
        int OldIndxOfLastShift { get; set; }
        int NewIndxOfLastShift { get; set; }
        int[] Values { get;}
        int LastCheckedIndx { get; set; }

        float[] GetValuesNormalized();
    }
}
