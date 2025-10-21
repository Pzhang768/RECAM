using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Remp.Models.Entities;

public class RempDbContext : IdentityDbContext<User>
{
  public RempDbContext(DbContextOptions<RempDbContext> options) : base(options) { }

  public DbSet<ListingCase> ListingCases { get; set; }
  public DbSet<CaseContact> CaseContacts { get; set; }
  public DbSet<MediaAsset> MediaAssets { get; set; }
  public DbSet<Agent> Agents { get; set; }
  public DbSet<PhotographyCompany> PhotographyCompanies { get; set; }
  public DbSet<AgentListingCase> AgentListingCases { get; set; }
  public DbSet<AgentPhotographyCompany> AgentPhotographyCompanies { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Agent>(entity =>
    {
      entity.HasKey(a => a.Id);

      entity.HasOne(a => a.AgentUser)
            .WithOne(u => u.UserAgentProfile)
            .HasForeignKey<Agent>(a => a.Id)
            .OnDelete(DeleteBehavior.Cascade);
    });

    modelBuilder.Entity<PhotographyCompany>(entity =>
    {
      entity.HasKey(pc => pc.Id);

      entity.HasOne(pc => pc.PhotographyCompanyUser)
            .WithOne(u => u.UserPhotographyCompanyProfile)
            .HasForeignKey<PhotographyCompany>(pc => pc.Id)
            .OnDelete(DeleteBehavior.Cascade);
    });

    modelBuilder.Entity<ListingCase>(entity =>
    {
      entity.HasKey(lc => lc.Id);

      entity.Property(lc => lc.Id)
            .ValueGeneratedOnAdd();

      entity.HasOne(lc => lc.ListingCaseUser)
            .WithMany()
            .HasForeignKey(lc => lc.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    });

    modelBuilder.Entity<CaseContact>(entity =>
    {
      entity.HasKey(cc => cc.ContactId);

      entity.Property(cc => cc.ContactId)
            .ValueGeneratedOnAdd();

      entity.HasOne(cc => cc.CaseContactListingCase)
            .WithMany()
            .HasForeignKey(cc => cc.ListingCaseId)
            .OnDelete(DeleteBehavior.Cascade);
    });

    modelBuilder.Entity<MediaAsset>(entity =>
    {
      entity.HasKey(ma => ma.Id);

      entity.Property(ma => ma.Id)
            .ValueGeneratedOnAdd();

      entity.HasOne(ma => ma.MediaAssetListingCase)
            .WithMany()
            .HasForeignKey(ma => ma.ListingCaseId)
            .OnDelete(DeleteBehavior.Cascade);

      entity.HasOne(ma => ma.MediaAssetUser)
            .WithMany()
            .HasForeignKey(ma => ma.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    });

    modelBuilder.Entity<AgentListingCase>(entity =>
    {
      entity.HasKey(alc => new { alc.AgentId, alc.ListingCaseId });

      entity.HasOne(alc => alc.Agent)
            .WithMany()
            .HasForeignKey(alc => alc.AgentId)
            .OnDelete(DeleteBehavior.Cascade);

      entity.HasOne(alc => alc.ListingCase)
            .WithMany()
            .HasForeignKey(alc => alc.ListingCaseId)
            .OnDelete(DeleteBehavior.Cascade);
    });

    modelBuilder.Entity<AgentPhotographyCompany>(entity =>
    {
      entity.HasKey(apc => new { apc.AgentId, apc.PhotographyCompanyId });

      entity.HasOne(apc => apc.Agent)
            .WithMany()
            .HasForeignKey(apc => apc.AgentId)
            .OnDelete(DeleteBehavior.Cascade);

      entity.HasOne(apc => apc.PhotographyCompany)
            .WithMany()
            .HasForeignKey(apc => apc.PhotographyCompanyId)
            .OnDelete(DeleteBehavior.Cascade);
    });
  }
}
