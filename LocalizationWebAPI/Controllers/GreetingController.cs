using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationWebAPI.Controllers;

[Route("{culture:culture}/[controller]")]
[ApiController]
public class GreetingController : ControllerBase
{
    private readonly IStringLocalizer<GreetingController> localizer;

    public GreetingController(IStringLocalizer<GreetingController> localizer)
    {
        this.localizer = localizer;
    }

    [HttpGet]
    public string Get()
    {
        return localizer["Greeting"];
    }
}
