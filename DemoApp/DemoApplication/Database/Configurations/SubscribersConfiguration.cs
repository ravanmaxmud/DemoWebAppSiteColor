﻿using DemoApplication.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoApplication.Database.Configurations
{
    public class SubscribersConfiguration
    {
        public void Configure(EntityTypeBuilder<Subscribes> builder)
        {
            builder
               .ToTable("Subscribers");
        }
    }
}
