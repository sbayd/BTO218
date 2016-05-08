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

        public bool IsPositionEnabled { get; set; }

        public bool IsColorEnabled { get; set; }

        public bool IsAudioEnabled { get; set; }
    }
}
