using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class SortValueWithoutNormalizationMock : ISortValues {

        int[] _values;


        public int[] Values { get => _values; set => _values = value; }
        public int OldIndxOfLastShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NewIndxOfLastShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SortValueWithoutNormalizationMock(int[] Values) {
            _values = Values;
        }

        public float[] GetValuesNormalized() {
            throw new NotImplementedException();
        }


    }
}
