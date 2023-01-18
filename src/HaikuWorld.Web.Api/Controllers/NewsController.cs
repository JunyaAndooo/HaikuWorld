using Microsoft.AspNetCore.Mvc;

namespace HaikuWorld.Web.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsController : ControllerBase
{
    private readonly NewsListApplicationService getNewsApplicationService;

    public NewsController(NewsListApplicationService getNewsApplicationService)
    {
        this.getNewsApplicationService = getNewsApplicationService;
    }

    [HttpGet]
    public async Task<ActionResult<List<NewsResult>>> News()
    {


        return Ok();
    }
}
