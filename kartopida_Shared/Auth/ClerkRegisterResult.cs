using System.Collections.Generic;

public class ClerkRegisterResult
{
    public bool Successful { get; set; }
    public IEnumerable<string> Errors { get; set; }
}
