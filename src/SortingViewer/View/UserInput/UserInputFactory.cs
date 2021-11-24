using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingViewer.View.UserInput {
    class UserInputFactory {
        public static UserInputControl CreateUserInputView() {
            UserInputControl uc = new UserInputControl();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            return uc;
        }
    }
}
