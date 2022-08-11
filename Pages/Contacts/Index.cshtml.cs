using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using contact_manager.Data;
using contact_manager.Models;

namespace contact_manager.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly contact_manager.Data.ContactContext _context;

        public IndexModel(contact_manager.Data.ContactContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contact != null)
            {
                Contact = await _context.Contact.ToListAsync();
            }
        }
    }
}
