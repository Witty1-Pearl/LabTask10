using System;
namespace HelperClasses
{
     interface ITaxable
    {
        decimal TaxValue();
    }
    
    
    class TaxableBus: Bus, ITaxable
    {
        public TaxableBus(int numberOfSeats, int regNumber, decimal value):
        base(numberOfSeats, regNumber, value)
        {

        }
           

        public decimal TaxValue()
        {
            return (value / 10) + 105M * numberOfSeats;
        }
            
        

        

        class TaxableHouse: House, ITaxable {

        public TaxableHouse(string location, bool inCity, double area, decimal value):
        base(location, inCity, area, value)
        {

        }
        
    }
}

   
    

       
        
            
               
   
