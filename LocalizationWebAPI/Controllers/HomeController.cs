using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationWebAPI.Controllers;

[Route("{culture:culture}/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IStringLocalizer<HomeController> localizer;

    public HomeController(IStringLocalizer<HomeController> localizer)
    {
        this.localizer = localizer;
    }

    [HttpGet]
    public string Get()
    {           
        return localizer["Home"];
    }
}