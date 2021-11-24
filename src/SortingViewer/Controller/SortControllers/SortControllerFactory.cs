using SortingViewer.Controller.SortAlgorythmManagers;
using SortingViewer.Views.StatisticViews;
using SortingViewer.Views.UserInput;
using SortingViewer.Views.ValueViews;
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
