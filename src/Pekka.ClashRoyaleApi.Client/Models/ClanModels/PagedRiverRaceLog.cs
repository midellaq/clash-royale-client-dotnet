using Pekka.ClashRoyaleApi.Client.Contracts.Models;

namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    public class PagedRiverRaceLog : IPaged<RiverRaceLog>
    {
        public RiverRaceLog[] Items { get; set; }

        public Paging Paging { get; set; }
    }
}