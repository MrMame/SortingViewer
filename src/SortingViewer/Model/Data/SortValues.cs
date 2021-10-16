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
        /// The Funktion Calculates the norm value of number inside the max-min range of all numbers.
        /// Exmpl. {-50, -25, 0, 50} has a min of -50, a max of 50 , a range of 100 
        /// and a result of {0, 0.25, 0.5, 1} 
        /// Returned Number are floats rounded to 2 decimal places.
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
            int ValueRange = MaxVal - MinVal;
            // Normalize the Values
            float[] normVals = new float[values.Length];
            for(int i = 0; i <= values.Length - 1; i++) {
                normVals[i] = (float)Math.Round((float)(Math.Abs(values[i] - MinVal)) / ValueRange, 2);
            }
            return normVals;
        }
        #endregion
    }
}
