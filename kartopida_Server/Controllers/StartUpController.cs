using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]    
public class StartupController : Controller
{
    private readonly kartopidaDBContext _context;

    public StartupController(kartopidaDBContext context)
    {
        _context = context;
    }

    // for startup info        
    [HttpGet("{startupName}")]
    public async Task<ActionResult<Startup>> Get(string startupName)
    {     
        return await _context.startups.FirstOrDefaultAsync(s => s.InternationalName == startupName);                
    }


    // for startup found
    [HttpPost]
    public async Task Post(Startup startup)
    {
        startup.founderID = 1 ;
        _context.startups.Add(startup);
        await _context.SaveChangesAsync();        
    }

    // for clerk feed
    // [Authorize]
    // [HttpGet("{field}")]
    // public async Task<List<Startup>> GetStartUpByField(string field)
    // {
    //     return await _context.startups.Where(s => s.Field == field)
    // }

    // for Announcement    
    // [HttpGet]
    // public async Task<ActionResult<Agahi>> GetAnnouncement(string title , string originName)
    // {            
    //         Startup origin = new Startup() ;
    //         foreach (var startup in _context.startups)            
    //             if(startup.name == originName)
    //             {
    //                 origin = startup ;
    //                 break ;
    //             }            

    //         return await origin.Agahiha.FirstOrDefaultAsync(s => s.name == startupName);                
            
    // }
}