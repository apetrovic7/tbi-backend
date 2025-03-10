using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/models")]
public class ModelController : ControllerBase
{
    [HttpGet("getModel")]
    public IActionResult GetModel()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Models/wwwroot/models/Headphone.glb");
        return PhysicalFile(filePath, "model/gltf-binary");
    }
}
