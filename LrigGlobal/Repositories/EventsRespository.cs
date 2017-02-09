using LrigGlobal.Models;
using LrigGlobal.Utils;
using Microsoft.Extensions.Options;

namespace LrigGlobal.Repositories
{
    public class EventsRepository : BasicRepository<Event>
    {
        public EventsRepository(IOptions<AppConfigurationSettings> configuration) : base(configuration, "events") { }
    }
}
