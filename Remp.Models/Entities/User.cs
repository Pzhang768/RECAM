using Microsoft.AspNetCore.Identity;

namespace Remp.Models.Entities;

public class User : IdentityUser
{
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public PhotographyCompany? UserPhotographyCompanyProfile { get; set; }
    public Agent? UserAgentProfile { get; set; }

    public User()
    {
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }

    public User(string userName, string email) : this()
    {
        UserName = userName;
        Email = email;
    }
}
