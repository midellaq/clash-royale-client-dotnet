using System;
using System.Collections.Generic;
using System.Text;

namespace Pekka.ClashRoyaleApi.Client.Contracts.Models
{
    public interface IRiverRaceParticipant : IModel
    {
        string Tag { get; set; }

        string Name { get; set; }

        public int Fame { get; set; }
        public int RepairPoints { get; set; }

        public int BoatAttacks { get; set; }

        public int DecksUsed { get; set; }

        public int DecksUsedToday { get; set; }

    }
}
