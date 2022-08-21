using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace SampleWebAPI.NET6.Controllers.Common
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class BaseController : ControllerBase
    {

    }
}