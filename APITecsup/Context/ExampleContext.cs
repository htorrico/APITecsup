using APITecsup.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APITecsup.Context
{
    public class ExampleContext : DbContext
    {
        public ExampleContext() : base("name = MyContextDB")
        {

        }

        public DbSet<Person> People  { get; set; }


    }
}