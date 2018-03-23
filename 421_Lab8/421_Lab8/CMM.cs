using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_Lab8
{
    class CMM
    {
        public string CoffeeType { get; set; }
        public int GrindingTime { get; set; }
        public int LEDNumber { get; set; }
        public int Temperature { get; set; }
        private List<Coffee> SalesRecords;

        public void AddCondiment(CondimentIF type)
        {

        }

        public double ComputePrice(Coffee cif)
        {
            var price = 0.0;

            return price;
        }

        public void Done()
        {

        }
    }
}
