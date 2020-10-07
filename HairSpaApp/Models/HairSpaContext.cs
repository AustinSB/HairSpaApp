namespace HairSpaApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HairSpaContext : DbContext
    {
        public HairSpaContext()
            : base("name=HairSpaModel")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.AccountsId);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomersId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeesId);
        }
    }
}
