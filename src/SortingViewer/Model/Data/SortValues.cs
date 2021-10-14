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
            // Calculate the Range fo Values for Referenze
            int MinVal = int.MaxValue;
            int MaxVal = int.MinValue;
            foreach(int Value in values) {
                if(Value < MinVal) MinVal = Value;
                if(Value > MaxVal) MaxVal = Value;
            }
            int ValueRange = MaxVal - (MinVal - 1);   // Range  100 - 1 = 99 !! Thats wrong for us. desired range is 100 and not 99 ! so minval -1
            // Normalize the Values
            float[] normVals = new float[values.Length];
            for(int i = 0; i <= values.Length - 1; i++) {
                normVals[i] = (float)values[i] / ValueRange;
            }
            return normVals;
        }
        #endregion
    }
}
