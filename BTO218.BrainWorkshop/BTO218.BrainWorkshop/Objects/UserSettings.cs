using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTO218.BrainWorkshop.Objects
{
    [Serializable]
    public class UserSettings
    {
        public string UserId { get; set; }

        public bool IsPositionEnabled { get; set; }

        public bool IsColorEnabled { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Level { get; set; }

    }
}
