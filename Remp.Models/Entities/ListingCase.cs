namespace Remp.Models.Entities;

public class ListingCase
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Postcode { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public double Price { get; set; }
    public int? Bedrooms { get; set; }
    public int? Bathrooms { get; set; }
    public int? Garages { get; set; }
    public double? FloorArea { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
    public PropertyKind? PropertyType { get; set; }
    public ListcaseState? ListcaseStatus { get; set; }
    public SaleMode? SaleCategory { get; set; }

    public required string UserId { get; set; }
    public required User ListingCaseUser { get; set; }

    public ListingCase(
        string userId,
        User listingCaseUser,
        string title,
        string description,
        string street,
        string city,
        string state,
        int postcode,
        double price,
        decimal? longitude = null,
        decimal? latitude = null,
        int? bedrooms = null,
        int? bathrooms = null,
        int? garages = null,
        double? floorArea = null,
        PropertyKind? propertyType = null,
        ListcaseState? listcaseStatus = null,
        SaleMode? saleCategory = null)
    {
        UserId = userId;
        ListingCaseUser = listingCaseUser;
        Title = title;
        Description = description;
        Street = street;
        City = city;
        State = state;
        Postcode = postcode;
        Price = price;
        Longitude = longitude;
        Latitude = latitude;
        Bedrooms = bedrooms;
        Bathrooms = bathrooms;
        Garages = garages;
        FloorArea = floorArea;
        PropertyType = propertyType;
        ListcaseStatus = listcaseStatus;
        SaleCategory = saleCategory;
        CreatedAt = DateTime.UtcNow;
    }
}
