using CentruDeTransfuzie1;
using CentruDeTransfuzie1.Data;
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
                DbInitializer.Initialize(db);
            }

        }
    }
}
