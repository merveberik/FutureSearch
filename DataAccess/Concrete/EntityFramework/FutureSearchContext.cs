using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class FutureSearchContext : DbContext
    {


        public DbSet<Category> Categories { get; set; }
    }
}
