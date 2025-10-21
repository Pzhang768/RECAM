namespace Remp.Models.Entities;

public class AgentPhotographyCompany
{
  public required string AgentId { get; set; }
  public required Agent Agent { get; set; }

  public required string PhotographyCompanyId { get; set; }
  public required PhotographyCompany PhotographyCompany { get; set; }

  public AgentPhotographyCompany(string agentId, Agent agent, string photographyCompanyId, PhotographyCompany photographyCompany)
  {
    AgentId = agentId;
    Agent = agent;
    PhotographyCompanyId = photographyCompanyId;
    PhotographyCompany = photographyCompany;
  }
}
