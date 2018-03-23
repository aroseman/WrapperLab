using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_Lab8
{
    abstract class Coffee : CoffeeIF
    {
        public double Price { get; private set; }
        public abstract void run(CMM cmm);
    }
}
