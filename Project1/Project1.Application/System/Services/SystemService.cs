using Microsoft.Extensions.Logging;
using Project1.EntityFramework.Core.Models;

namespace Project1.Application
{
    public partial class SystemService : ISystemService, ITransient
    {
        private readonly IRepository<QV_Report> _repo;
        private readonly ILogger<SystemService> _logger;

        public SystemService(IRepository<QV_Report> repo,ILogger<SystemService> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public string GetDescription()
        {
            var result = _repo.Where(m => m.Id > 1050);
            var i = 1;
            var j = 0;
            //var k = i / j;
            throw Oops.Oh(300, " error data");
            _logger.LogInformation("result",result.Count());
            return result.Count().ToString();
        }
    }
}