namespace Remp.Models.Entities;

public class CaseContact
{
    public int ContactId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string CompanyName { get; set; }
    public string? ProfileUrl { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public required int ListingCaseId { get; set; }
    public required ListingCase CaseContactListingCase { get; set; }

    public CaseContact(string firstName, string lastName, string companyName, int listingCaseId, ListingCase caseContactListingCase, string? profileUrl = null, string? email = null, string? phoneNumber = null)
    {
        FirstName = firstName;
        LastName = lastName;
        CompanyName = companyName;
        ListingCaseId = listingCaseId;
        CaseContactListingCase = caseContactListingCase;
        ProfileUrl = profileUrl;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}
