using CentruDeTransfuzie1;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db=new CTContext(new DbContextOptions<CTContext>()))
            {
                db.Database.EnsureCreated();
                Console.Write("Hello World");
            }
        }
    }
}
