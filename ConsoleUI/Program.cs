using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            //RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 04, 01), ReturnDate = null });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else { Console.WriteLine(result.Message); }
        }

        
        
    }
}
