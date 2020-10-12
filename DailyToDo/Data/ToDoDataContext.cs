using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyToDo.Data.DataConfiguration;

namespace DailyToDo.Data
{
    public class ToDoDataContext : DbContext
    {
        public DbSet<ToDo> AllToDo { get; set; }

        public ToDoDataContext(DbContextOptions<ToDoDataContext> options) : base(options)
        {
        }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
             {

            modelBuilder.ApplyConfiguration(new ToDoConfiguration());
              }


         

     }
}