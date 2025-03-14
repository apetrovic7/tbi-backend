using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/models")]
public class ModelController : ControllerBase
{
    [HttpGet("getModel")]
    public IActionResult GetModel()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Models/wwwroot/models/plain_mug.glb");
        return PhysicalFile(filePath, "model/gltf-binary");
    }
}
