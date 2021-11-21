using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class SortValueWithoutNormalizationMock : ISortValues {

        int[] _values;


        public int[] Values { get => _values; set => _values = value; }

        public SortValueWithoutNormalizationMock(int[] Values) {
            _values = Values;
        }

        public float[] GetValuesNormalized() {
            throw new NotImplementedException();
        }


    }
}
