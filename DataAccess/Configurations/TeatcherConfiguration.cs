using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations
{
    public class TeatcherConfiguration : IEntityTypeConfiguration<Teatcher>
    {
        public void Configure(EntityTypeBuilder<Teatcher> builder)
        {

        }
    }
}
