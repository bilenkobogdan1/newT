using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class BaseControl : ControllerBase
    {
    }
}
