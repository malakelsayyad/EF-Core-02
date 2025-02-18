using Demo.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configuration
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            //D.Property(D => D.Id)
            // .UseIdentityColumn(10, 10);

            //D.Property(D => D.DeptName)
            // .IsRequired(false)
            // .HasDefaultValue("DepartmentTest");

            //D.Property(D => D.DateOfCreation)
            //    .HasComputedColumnSql("GETDATE()");
        }
    }
}
