using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODataFx
{
    public class Repository: DbContext
    {
        public Repository() :base("OData-Playground")
        {

        }

        public DbSet<Person> People { get; set; }

    }
}