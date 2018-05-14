using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNet
{
    class VM_Locator
    {
        public VM_mainWindow MainWindow { get; set; }

        public VM_Locator()
        {
            MainWindow = new VM_mainWindow();
        }
    }
}
