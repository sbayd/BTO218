using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTO218.BrainWorkshop.Objects
{
    /// <summary>
    /// Kullanıcı ayarlarını saklamak için kullandığımız nesne.
    /// </summary>
    [Serializable]
    public class UserSettings
    {
        /// <summary>
        /// Kullanıcının Unique ID'si - Mail adresi
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Oyun türü -> Pozisyon modu açık mı
        /// </summary>
        public bool IsPositionEnabled { get; set; }

        /// <summary>
        /// Oyun türü -> Renk modu açık mı
        /// </summary>
        public bool IsColorEnabled { get; set; }

        /// <summary>
        /// Ad 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Soyad
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// N-Back seviyesi
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Nesne üzerindeki son değişim tarihi
        /// </summary>
        public DateTime ModifiedDate { get; set; }

    }
}
