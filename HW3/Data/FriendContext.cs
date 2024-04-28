using HW4.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HW4.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext(DbContextOptions<FriendContext> options) : base(options) { }

        public DbSet<Friend> Friend { get; set; }
    }
}
