using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data
{
    public interface ISortValues
    {
        int[] Values { get; set; }
        float[] GetValuesNormalized();
    }
}
