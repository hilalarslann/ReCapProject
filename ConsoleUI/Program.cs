using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarName);
            }

            Console.ReadLine();
        }
    }
}
