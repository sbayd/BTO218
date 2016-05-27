using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTO218.BrainWorkshop.Objects
{
    /// <summary>
    ///  Oyun türüne göre ikisi ya da biri kullanılan materyal dosyası, ilgili turda kullanılacak pozisyon(1-9) ve Renk verisi burada tutulur.
    /// </summary>
    public class GameMaterial
    {
        public int PositionNumber { get; set; }

        public Color color { get; set; }

    }
}
