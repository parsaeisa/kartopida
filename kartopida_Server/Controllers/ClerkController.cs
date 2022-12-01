using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ClerkController : Controller
{
    private readonly kartopidaDBContext _context;

    public ClerkController(kartopidaDBContext context)
    {
        _context = context;
    }

    // for clerk profile
    [HttpGet("getByUserName/{username}")]
    public async Task<ActionResult<Clerk>> Get(string username)
    {           
        return await _context.clerks.FirstOrDefaultAsync(s => s.username == username); 
    }            

    // for clerk sign  up
    [HttpPost]
    public async Task Post(Clerk clerk)
    {        
        _context.clerks.Add(clerk);
        await _context.SaveChangesAsync();        
    }

}