using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using LibraryMSMVC.Models;

namespace LibraryMSMVC
{
    public partial class LibraryDB : DbContext
    {
        public LibraryDB()
            : base("name=LibraryDB")
        {
        }

        public virtual DbSet<tblAdmin> tblAdmins { get; set; }
        public virtual DbSet<tblBook> tblBooks { get; set; }
        public virtual DbSet<tblTransaction> tblTransactions { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblBook>()
                .Property(e => e.DateAdded)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.UserGender)
                .IsFixedLength();

            modelBuilder.Entity<tblUser>()
                .Property(e => e.UserDep)
                .IsFixedLength();
        }
    }
}
