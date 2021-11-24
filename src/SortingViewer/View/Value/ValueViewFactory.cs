using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.View.Value {
    public class ValueViewFactory {
        public static ValuesBarView CreateValueBarView() {
            ValuesBarView vv = new ValuesBarView();
            vv.Dock = System.Windows.Forms.DockStyle.Fill;
            return vv;
        }
    }
}
