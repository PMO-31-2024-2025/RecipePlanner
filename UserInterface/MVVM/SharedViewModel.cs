using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.MVVM
{
    class SharedViewModel : BaseViewModel
    {
        public AccountViewModel AccountVM = new AccountViewModel();
    }
}
