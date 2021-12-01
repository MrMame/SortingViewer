using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Model.Data.SortValues {
    public class SortValues : ISortValues {

        int[] _values;
        int _OldIndxofLastShift=0;
        int _NewIndxofLastShift=0;
        int _LastCheckedIndex = 0;

        #region PROPERTIES
        /// <summary>
        /// Raw Values
        /// </summary>
        public int[] Values { get => _values; }
        public int OldIndxOfLastShift { get => _OldIndxofLastShift; set => _OldIndxofLastShift = value; }
        public int NewIndxOfLastShift { get => _NewIndxofLastShift; set => _NewIndxofLastShift = value; }
        public int LastCheckedIndx { get => _LastCheckedIndex; set => _LastCheckedIndex = value; }
        #endregion



        #region PUBLICS
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ValuesList"></param>
        public SortValues(params int[] ValuesList) {
            _values = ValuesList;
        }
        /// <summary>
        /// Returns a Normalized Array of the values 
        /// </summary>
        /// <returns></returns>
        public float[] GetValuesNormalized() {
            return CreateNormalized(_values);
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
