using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data.SortValues
{
    public interface ISortValues
    {
        int[] Values { get;}
        float[] GetValuesNormalized();
    }
}
