using SortingViewer.Controller;
using SortingViewer.Model.SortAlgorythm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer_Tests.TestingMocks {
    class SortAlgorythmManager_StandardMock:ISortAlgorythmManager {

        Dictionary<String, ISortAlgorythm> _SortAlgos = new Dictionary<String, ISortAlgorythm>();

        public SortAlgorythmManager_StandardMock() {
        }

        /// <summary>
        /// Returns the Algorythm with the given Name
        /// </summary>
        /// <param name="SortAlgorythmName">Name of the Algorythm to be returned</param>
        /// <returns></returns>
        public ISortAlgorythm GetAlgorythm(string SortAlgorythmName) {
            return _SortAlgos[SortAlgorythmName];
        }
        /// <summary>
        /// Returns a List of String with all Names of Algorythms.
        /// </summary>
        /// <returns></returns>
        public List<string> GetSortAlgorythmsNames() {
            return _SortAlgos.Keys.ToList<string>();
        }

        /// <summary>
        /// Adds a Alorythm to the Managers Dictionary
        /// </summary>
        /// <param name="UniqueName">A Unique Name representing the SortAlgorythm</param>
        /// <param name="SortAlgorythm">SortAlgorythm to be stored</param>
        /// <exception cref="ArgumentException" >If UniqueName is NULL or Empty</exception>
        public void AddAlgorythm(string UniqueName, ISortAlgorythm SortAlgorythm) {
            if(UniqueName == "") throw new ArgumentException("Empty Name is not allowed");
            _SortAlgos.Add(UniqueName, SortAlgorythm);
        }
    }
}
