using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILoggerManager _logger;
        private IRepositoryWrapper _repositoryWrapper;
        public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var domesticAccounts = _repositoryWrapper.AccountRepository.FindByCondition(x => x.AccountType.Equals("s"));
            var owners = _repositoryWrapper.OwnerRepository.FindAll();
            return new string[] { "value1", "value2" };
        }
    }
}