namespace IocAutofac.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<Accession> Accession { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Borrower> Borrower { get; set; }
        public virtual DbSet<Loan> Loan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accession>()
                .HasMany(e => e.Loan)
                .WithOptional(e => e.Accession1)
                .HasForeignKey(e => e.Accession);

            modelBuilder.Entity<Book>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Publisher)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.Forename)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Borrower>()
                .HasMany(e => e.Loan)
                .WithOptional(e => e.Borrower1)
                .HasForeignKey(e => e.Borrower);
        }
    }
}
