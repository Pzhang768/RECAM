namespace Remp.Models.Entities;

public class Agent
{
    public required string Id { get; set; }
    public required User AgentUser { get; set; }
    public required string AgentFirstName { get; set; }
    public required string AgentLastName { get; set; }
    public string? AvatarUrl { get; set; }
    public required string CompanyName { get; set; }

    public Agent(string id, User agentUser, string agentFirstName, string agentLastName, string companyName, string? avatarUrl = null)
    {
        Id = id;
        AgentUser = agentUser;
        AgentFirstName = agentFirstName;
        AgentLastName = agentLastName;
        CompanyName = companyName;
        AvatarUrl = avatarUrl;
    }
}
