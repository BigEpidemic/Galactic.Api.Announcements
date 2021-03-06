using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Galactic.Api.Announcements.Models
{
    public class AnnouncementContext : DbContext
    {
        public AnnouncementContext(DbContextOptions<AnnouncementContext> options) : base (options)
        {

            
        }

        public DbSet<Announcement> Announcements { get; set; }
    }
}
