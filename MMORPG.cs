using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_2
{
    public class MMORPG : VideoGame
    {
        public bool CharacterCreation { get; set; }

        public bool OpenWorld { get; set; }

        public bool PaidSubscription { get; set; }

        public Decimal SubscriptionCost { get; set; }

    }
}
