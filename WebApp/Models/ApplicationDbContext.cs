using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Data Source=DESKTOP-H1L0P1R;Initial Catalog=DBPRUEBA;Integrated Security=True;")
        {
        }
    }
}