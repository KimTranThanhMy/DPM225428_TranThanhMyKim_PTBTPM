using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225428_TranThanhMyKim_Real10_Facade
{
    internal class Customer
    {
        private string name;
        // Constructor
        public Customer(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
