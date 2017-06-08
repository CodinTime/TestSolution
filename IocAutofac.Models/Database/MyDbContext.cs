namespace IocAutofac.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext1")
        {
        }

        public virtual DbSet<Accession> Accession { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Borrower> Borrower { get; set; }
        public virtual DbSet<Loan> Loan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accession>()
                .Property(e => e.Accession1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Accession>()
                .Property(e => e.ISBN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Book>()
                .Property(e => e.ISBN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Book>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Publisher)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasOptional(e => e.Accession)
                .WithRequired(e => e.Book);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.Forename)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.Surname)
                .IsUnicode(false);
        }
    }
}
