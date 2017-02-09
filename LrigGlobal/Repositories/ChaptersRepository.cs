using LrigGlobal.Models;
using LrigGlobal.Utils;
using Microsoft.Extensions.Options;

namespace LrigGlobal.Repositories
{
    public class ChaptersRepository : BasicRepository<Chapter>
    {
        public ChaptersRepository(IOptions<AppConfigurationSettings> configuration) : base(configuration, "chapters") { }
    }
}
