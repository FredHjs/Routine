using Microsoft.EntityFrameworkCore;
using Routine.Entities;
using Routine.Services;
using System;

namespace Routine.Data
{
    public class RoutineDbContext:DbContext
    {
        public RoutineDbContext(DbContextOptions<RoutineDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(x => x.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Company>()
                .Property(x => x.Introduction).HasMaxLength(500);
            modelBuilder.Entity<Employee>()
                .Property(x => x.EmployeeNo).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Employee>()
                .Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>()
                .Property(x => x.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>().HasOne(x => x.Company)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.CompanyId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = Guid.Parse("d502f792-b007-4262-823e-26abd4666dce"),
                    Name = "Microsoft",
                    Introduction = "Great Company",
                    Country = "USA",
                    Product = "Software",
                    Industry = "Software"
                }, new Company
                {
                    Id = Guid.Parse("9babffca-c2aa-4ff6-a4ee-0a22682d239e"),
                    Name = "Google",
                    Introduction = "Don't be evil",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Software"
                }, new Company
                {
                    Id = Guid.Parse("29e02aef-3144-4f2a-ad19-4499a2732955"),
                    Name = "Alipapa",
                    Introduction = "Fubao Company",
                    Country = "China",
                    Industry = "Internet",
                    Product = "Software"
                },new Company
                {
                    Id = Guid.Parse("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"),
                    Name = "Amazon",
                    Introduction = "Sells Everything",
                    Country = "USA",
                    Industry = "Internet",
                    Product = "Software"

                }, new Company
                {
                    Id = Guid.Parse("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"),
                    Name = "SpaceX",
                    Introduction = "High Tech company",
                    Country = "USA",
                    Industry = "Aerospace",
                    Product = "Aircrafts"
                }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.Parse("2e996af1-654e-4a07-9d38-0e1b0a1ab8cc"),
                    CompanyId = Guid.Parse("d502f792-b007-4262-823e-26abd4666dce"),
                    DateOfBirth = new DateTime(1976, 1, 2),
                    EmployeeNo = "MSFT231",
                    FirstName = "Nick",
                    LastName = "Carton",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("e0dae939-4275-4df9-95d5-317b72ae4526"),
                    CompanyId = Guid.Parse("d502f792-b007-4262-823e-26abd4666dce"),
                    DateOfBirth = new DateTime(1981,12,5),
                    EmployeeNo = "MSFT235",
                    FirstName = "Vince",
                    LastName = "Carter",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("c83404ff-c8a4-45a9-8f89-ce727a70f080"),
                    CompanyId = Guid.Parse("9babffca-c2aa-4ff6-a4ee-0a22682d239e"),
                    DateOfBirth = new DateTime(1991,7,5),
                    EmployeeNo = "Gole167",
                    FirstName = "Fred",
                    LastName = "Huang",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("eedd02c5-46de-9dde-ec34-a44b2be1759a"),
                    CompanyId = Guid.Parse("3b4c5c92-cc8c-905b-3563-fdbe7bd466b2"),
                    DateOfBirth = new DateTime(1982, 3, 22),
                    EmployeeNo = "Amazon17",
                    FirstName = "Lyn",
                    LastName = "Liu",
                    Gender = Gender.女
                },new Employee
                {
                    Id = Guid.Parse("18bc9ce1-8a71-64cd-fdd6-4021b4becd0d"),
                    CompanyId = Guid.Parse("eb94cf6f-e050-4fa0-3cc4-4ad6f2156e04"),
                    DateOfBirth = new DateTime(1978, 11, 30),
                    EmployeeNo = "SpaceX867",
                    FirstName = "George",
                    LastName = "Li",
                    Gender = Gender.女
                }
                ) ;

        }

        public static implicit operator RoutineDbContext(CompanyRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
