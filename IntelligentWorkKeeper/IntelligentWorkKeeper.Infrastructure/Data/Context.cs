using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using IntelligentWorkKeeper.Domain.Models;

namespace IntelligentWorkKeeper.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public DbSet<IntelligentWork> IntelligentWorks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Indexation> Indexations { get; set; }
        public DbSet<KeyWord> KeyWords { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<RegistrationCertificate> RegistrationCertificates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
