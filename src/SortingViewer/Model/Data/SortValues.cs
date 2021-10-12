using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data {
    public class SortValues : ISortValues {

        int[] _values;
        float[] _normalizedValues;
        int _highestNumber;



        #region PROPERTIES
        /// <summary>
        /// Raw Values
        /// </summary>
        public int[] Values { 
            get { return _values; }
            set{ _values = value; }
        }
        #endregion



        #region PUBLICS
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ValuesList"></param>
        public SortValues(params int[] ValuesList) {
            _values = ValuesList;
            _normalizedValues = CreateNormalized(ValuesList);
        }
        /// <summary>
        /// Returns a Normalized Array of the values 
        /// </summary>
        /// <returns></returns>
        public float[] GetValuesNormalized() {
            return _normalizedValues;
        }
        #endregion



        #region PRIVATES
        /// <summary>
        /// Creates a Normalized Array of the values.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private float[] CreateNormalized(int[] values) {
            float[] retVals = new float[values.Length];
            if(values.Length > 0) { 
                _highestNumber = _values.Max();
                for(int i = 0; i <= values.Length - 1; i++) {
                    retVals[i] = (float)values[i] / _highestNumber;
                }
            }
            return retVals;
        }
        #endregion
    }
}
