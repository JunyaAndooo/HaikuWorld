using Microsoft.AspNetCore.Mvc;

namespace HaikuWorld.Web.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsController : ControllerBase
{
    //private readonly NewsListApplicationService getNewsApplicationService;

    public NewsController()
    {
    }

    [HttpGet]
    public async Task<ActionResult> News()
    {


        return Ok();
    }
}
