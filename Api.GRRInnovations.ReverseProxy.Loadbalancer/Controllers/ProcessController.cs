using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Api.GRRInnovations.ReverseProxy.Loadbalancer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessController : ControllerBase
    {
        private readonly IDistributedCache _cache;
        private readonly string _instanceName;

        public ProcessController(IDistributedCache cache, IConfiguration config)
        {
            _cache = cache;
            _instanceName = Environment.GetEnvironmentVariable("InstanceName") ?? "UNKNOWN";
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var delay = new Random().Next(100, 800);
            await Task.Delay(delay);

            var countStr = await _cache.GetStringAsync("global_count");
            var count = string.IsNullOrEmpty(countStr) ? 0 : int.Parse(countStr);
            count++;

            await _cache.SetStringAsync("global_count", count.ToString());

            return Ok(new
            {
                instance = _instanceName,
                delayMs = delay,
                counter = count
            });
        }
    }
}
