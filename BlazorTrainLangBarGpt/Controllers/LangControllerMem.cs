using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace YourProject.Controllers
{
    [Route("api/lang")]
    [ApiController]
    public class LangControllerMem : ControllerBase
    {
        private const string LangCacheKey = "currentLanguage";
        private readonly IMemoryCache _memoryCache;

        public LangControllerMem(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("current")]
        public IActionResult GetCurrentLanguage()
        {
            if (!_memoryCache.TryGetValue(LangCacheKey, out string currentLanguage))
            {
                currentLanguage = "en-us"; // Default language
                _memoryCache.Set(LangCacheKey, currentLanguage);
            }
            return Ok(currentLanguage);
        }

        [HttpPost("set")]
        public IActionResult SetCurrentLanguage([FromBody] string language)
        {
            _memoryCache.Set(LangCacheKey, language);
            return Ok();
        }
    }
}