﻿using Demo.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configuration
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            //E.HasKey(E => E.Id);
            //E.Property(E => E.Name)
            // .IsRequired(true)
            // .HasColumnType("varchar")
            // .HasMaxLength(50)
            // .HasColumnName("EmployeeName");

            //E.Property(E => E.Age).IsRequired(false);

            //E.Property(E => E.Salary).HasColumnType("money");


        }
    }
}