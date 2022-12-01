using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class EntrepreneurController : Controller
{
    private readonly kartopidaDBContext _context;

    public EntrepreneurController(kartopidaDBContext context)
    {
        _context = context;
    }

    //for entrepreneur profile
    // worked
    [HttpGet("{id}")]
    public async Task<ActionResult<Entrepreneur>> Get(string id)
    {
        return await _context.entrepreneurs.FirstOrDefaultAsync(s => s.username == id); 
    }   

    // for entrepreneur sign up
    [HttpPost]
    public async Task Post(Entrepreneur entrepreneur)
    {
        _context.entrepreneurs.Add(entrepreneur);
        await _context.SaveChangesAsync();        
    }     
        
}