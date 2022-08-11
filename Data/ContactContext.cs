using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using contact_manager.Models;

namespace contact_manager.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options)
            : base(options)
        {
        }

        public DbSet<contact_manager.Models.Contact> Contact { get; set; } = default!;
    }
}
