namespace UploadingImagesToDatabaseWithApi.Shared;

public class QrBuildingProblem
{
    public int Id { get; set; }
    public string? BuildingName { get; set; }
    public string? Description { get; set; }
    public List<Image>? Images { get; set; } = new();
    public string? UserName { get; set; }
    public string? UserTelephone { get; set; }
    public string? UserEmail { get; set; }
}