namespace Remp.Models.Entities;

public class PhotographyCompany
{
    public required string Id { get; set; }
    public required User PhotographyCompanyUser { get; set; }
    public required string PhotographyCompanyName { get; set; }

    public PhotographyCompany(string id, User photographyCompanyUser, string photographyCompanyName)
    {
        Id = id;
        PhotographyCompanyUser = photographyCompanyUser;
        PhotographyCompanyName = photographyCompanyName;
    }
}
