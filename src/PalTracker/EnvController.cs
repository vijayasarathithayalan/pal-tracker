using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("env")]
    public class EnvController : ControllerBase
    {
        private readonly CloudFoundryInfo _cloudFoundryInfo;

        [HttpGet]
        public CloudFoundryInfo Get() => _cloudFoundryInfo;

        public EnvController(CloudFoundryInfo cloudFoundryEnv)
        {
            _cloudFoundryInfo = cloudFoundryEnv;
        }
    }
}