using System;

namespace HelperClasses
{
    class Program
    {
        static void Main(string[] args)
        {
             ITaxable[] tObjects = 
             new ITaxable[]{
             new TaxableHouse("Lagos", true, 700, 500000M),
             new TaxableHouse("Adamawa", true, 1800, 300000M),
             new TaxableBus(50, 12345, 300000M),
             new TaxableBus(10, 345678, 25000M)}; 

             foreach(ITaxable it in tObjects)
             Console.WriteLine("{0}", it.TaxValue());
        }
    }
}
