using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_Lab8
{
    class CoffeeWrapper : Coffee
    {
        public Coffee Coffee { get; set; }
        public CondimentIF Condiment { get; set; }

        public void run(CMM cmm)
        {
            throw new NotImplementedException();
        }
    }
}
