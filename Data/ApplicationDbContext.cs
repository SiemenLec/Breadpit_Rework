﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
using BreadpitProject.Models;

namespace ContactManager.Data;

public class ApplicationDbContext : IdentityDbContext
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        : base(options)
    {
    }
    public DbSet<Contact> Contact { get; set; }
    public DbSet<BreadpitProject.Models.Sandwich>? Sandwich { get; set; }
    public DbSet<BreadpitProject.Models.Order>? Order { get; set; }
    public DbSet<BreadpitProject.Models.OrderDetail>? OrderDetail { get; set; }
}
