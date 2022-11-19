using Microsoft.AspNetCore.Mvc;
using UploadingImagesToDatabaseWithApi.Shared;

namespace UploadingImagesToDatabaseWithApi.Server.Controller;

[ApiController]
[Route("[controller]")]
public class BuildingProblemController : ControllerBase
{
    private readonly DatabaseContext _databaseContext;

    public BuildingProblemController(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    [HttpPost]
    [Route("uploadbuildingproblem")]
    public IActionResult CreateBuildingProblem(QrBuildingProblem buildingProblem)
    {
        _databaseContext.BuildingProblems?.Add(buildingProblem);
        _databaseContext.SaveChanges();
        return Ok(buildingProblem);
    }
}