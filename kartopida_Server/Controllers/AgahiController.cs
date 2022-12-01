using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]    
public class AgahiController : Controller
{
    private readonly kartopidaDBContext _context;

    public AgahiController(kartopidaDBContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post(Agahi announcement)
    {
        announcement.originID = 1 ;
        _context.announcements.Add(announcement);
        await _context.SaveChangesAsync();
        return _context.announcements
                            .Select(a => a.AnnouncementID)
                            .Max();        
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Agahi>> Get(int id)
    {           
        return await _context.announcements.FirstOrDefaultAsync(s => s.AnnouncementID == id); 
    }            
}