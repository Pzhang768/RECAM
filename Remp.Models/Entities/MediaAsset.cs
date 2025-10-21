namespace Remp.Models.Entities;

public class MediaAsset
{
    public int Id { get; set; }
    public required MediaKind MediaType { get; set; }
    public required string MediaUrl { get; set; }
    public DateTime UploadedAt { get; set; }
    public bool IsSelect { get; set; } = false;
    public bool IsHero { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public required int ListingCaseId { get; set; }
    public required ListingCase MediaAssetListingCase { get; set; }
    public required string UserId { get; set; }
    public required User MediaAssetUser { get; set; }

    public MediaAsset(MediaKind mediaType, string mediaUrl, int listingCaseId, ListingCase mediaAssetListingCase, string userId, User mediaAssetUser)
    {
        MediaType = mediaType;
        MediaUrl = mediaUrl;
        ListingCaseId = listingCaseId;
        MediaAssetListingCase = mediaAssetListingCase;
        UserId = userId;
        MediaAssetUser = mediaAssetUser;
        UploadedAt = DateTime.UtcNow;
    }
}
