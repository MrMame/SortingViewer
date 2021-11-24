using SortingViewer.Controller.SortAlgorythmManagers;
using SortingViewer.View.Statistic;
using SortingViewer.View.UserInput;
using SortingViewer.View.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.Controller.SortControllers {
    class SortControllerFactory {
        public static SortController CreateSortControllerWithPreloadedSortAlgorythms(IUserInput UI, IValueView Vview, IStatisticsView Sview) {
            SortController sc = new SortController( UI, 
                                                    Vview,   
                                                    Sview,
                                                    SortAlgorythmManagerFactory.CreatePreloadedManager());
            return sc;
        }
    }
}
