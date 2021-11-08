using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.Utilities {
    class MathUtils {

        /// <summary>
        /// Function for checking float values.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="delta">Range where floats are still equal</param>
        /// <returns>True when floats are nearly Equal in range of delta, false if not</returns>
        /// /// <remarks>https://stackoverflow.com/questions/3874627/floating-point-comparison-functions-for-c-sharp</remarks>
        public static bool NearlyEqual(float a, float b, float delta) {
             float absA = Math.Abs(a);
             float absB = Math.Abs(b);
             float diff = Math.Abs(a - b);
            
            if(a == b) { // shortcut, handles infinities
                return true;
            }
            else if(a == 0 || b == 0 || absA + absB < float.Epsilon) {
                // a or b is zero or both are extremely close to it
                // relative error is less meaningful here
                return diff < (delta * float.Epsilon);
            }
            else { // use relative error
                return diff / (absA + absB) < delta;
            }
        }

        /// <summary>
        /// Function for checking float values.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="delta">Range where floats are still equal</param>
        /// <returns>True when floats are nearly Equal in range of delta, false if not</returns>
        /// <remarks>https://stackoverflow.com/questions/3874627/floating-point-comparison-functions-for-c-sharp</remarks>
        public static bool NearlyEqual(double a, double b, double delta) {
            const double MinNormal = double.Epsilon;
            double absA = Math.Abs(a);
            double absB = Math.Abs(b);
            double diff = Math.Abs(a - b);

            if(a.Equals(b)) { // shortcut, handles infinities
                return true;
            }
            else if(a == 0 || b == 0 || absA + absB < MinNormal) {
                // a or b is zero or both are extremely close to it
                // relative error is less meaningful here
                return diff < (delta * MinNormal);
            }
            else { // use relative error
                return diff / (absA + absB) < delta;
            }
        }

    }
}
