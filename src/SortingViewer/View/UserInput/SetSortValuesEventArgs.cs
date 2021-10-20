using SortingViewer.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Implementing Interface with own EventArgs Example
/// https://social.msdn.microsoft.com/Forums/de-DE/d1e6beac-7cc2-4c21-85bc-1ed5d6b4b913/how-do-i-specify-custom-eventargs-in-a-interface?forum=csharplanguage
/// </summary>
namespace SortingViewer.View.UserInput {
    public class SetSortValuesEventArgs : EventArgs {
        public ISortValues SortValues{get;set;}
    }
}
