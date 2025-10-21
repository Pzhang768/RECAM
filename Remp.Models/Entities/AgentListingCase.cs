namespace Remp.Models.Entities;

public class AgentListingCase
{
  public required string AgentId { get; set; }
  public required Agent Agent { get; set; }

  public required int ListingCaseId { get; set; }
  public required ListingCase ListingCase { get; set; }

  public AgentListingCase(string agentId, Agent agent, int listingCaseId, ListingCase listingCase)
  {
    AgentId = agentId;
    Agent = agent;
    ListingCaseId = listingCaseId;
    ListingCase = listingCase;
  }
}
