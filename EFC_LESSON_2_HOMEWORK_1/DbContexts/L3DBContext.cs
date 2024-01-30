using EFC_LESSON_2_HOMEWORK_1.Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EFC_LESSON_2_HOMEWORK_1.DbContexts
{
    public class L3DBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string ConnectionStr = "Server=DESKTOP-RV3QOTA\\SQLEXPRESS;Database=L3;User ID=login;Password=123;";

            optionsBuilder.UseSqlServer(ConnectionStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Categorle> Categorlees { get; set;}
        public DbSet<Department> Departments { get; set; }
        public DbSet<Facultie> Faculties { get; set;}
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<Press> Presss { get; set; }
        public DbSet<S_Card> S_Cards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<T_Card> T_Cards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }
}
