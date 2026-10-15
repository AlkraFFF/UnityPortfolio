namespace UnityPortfolio.Models;

public record Project(
    string Id,
    string Title,
    string Subtitle,
    string Description,
    string ThumbnailUrl,
    string[] Tags,
    string Category, // e.g., "3D Game", "Tool", "Shader/Tech Art", "Mobile"
    string? GameplayVideoUrl = null,
    string? ItchIoUrl = null,
    string? SteamUrl = null,
    string? GitHubUrl = null,
    string? PlayGoogleUrl = null
);