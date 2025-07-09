using Microsoft.EntityFrameworkCore;
using MVC_LuisF.Models;
using System.Collections.Generic;

namespace MVC_LuisF.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Producto> Producto { get; set; }
    }

}
