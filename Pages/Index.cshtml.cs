using contact_manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace contact_manager.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly contact_manager.Data.ContactContext _context;

    public IndexModel(ILogger<IndexModel> logger, contact_manager.Data.ContactContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IList<Contact> Contact { get; set; } = default!;

    //public void OnGet()
    //{

    //}

    public async Task OnGetAsync()
    {
        if (_context.Contact != null)
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}




