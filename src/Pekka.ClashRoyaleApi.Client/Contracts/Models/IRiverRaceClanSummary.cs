namespace Pekka.ClashRoyaleApi.Client.Contracts.Models
{
    public interface IRiverRaceClanSummary : IClanLight
    {
        public int Fame { get; set; }
        public int RepairPoints { get; set; }
        public string FinishTime { get; set; }

        int ClanScore { get; set; }
    }
}