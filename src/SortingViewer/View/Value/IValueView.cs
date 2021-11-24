﻿using SortingViewer.Model.Data.SortValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.View.Value
{
    public interface IValueView
    {
        void ShowValues(ISortValues Values);
        void ResetView();
    }
}
