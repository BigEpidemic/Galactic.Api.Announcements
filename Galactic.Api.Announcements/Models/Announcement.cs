using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Galactic.Api.Announcements.Models
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime PublishDate { get; set; } // Create announcements before you want them displayed-- queue them up!
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}
