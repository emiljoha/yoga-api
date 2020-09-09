using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace yoga_rest.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class YogaVideoController : ControllerBase
    {
        private readonly ILogger<YogaVideoController> _logger;

        public YogaVideoController(ILogger<YogaVideoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<YogaVideo> Get(VideoLengthInMinutes minutes)
        {
            var matchingVideos = YogaVideoStore.AllMatching(minutes);
            if (matchingVideos.Count != 0) {
                var choice = (new Random()).Next(matchingVideos.Count);
                return matchingVideos[choice];
            } else {
                return NotFound();
            }
        }
    }
}
