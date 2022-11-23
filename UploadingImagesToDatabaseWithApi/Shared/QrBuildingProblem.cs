using System.ComponentModel.DataAnnotations;

namespace UploadingImagesToDatabaseWithApi.Shared;

public class QrBuildingProblem
{
    public int Id { get; set; }

    [Required] public string? BuildingName { get; set; }

    [Required] public string? Description { get; set; }

    [Required] public List<Image>? Images { get; set; } = new();

    [Required] public string? UserName { get; set; }

    [Required] public string? UserTelephone { get; set; }

    [Required] public string? UserEmail { get; set; }
}