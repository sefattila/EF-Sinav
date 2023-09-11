using Sinav.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Core.Entities
{
    public class Album : BaseEntity
    {
        public string AlbumAdi { get; set; }
        public DateTime CikisTarihi { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public double Fiyat { get; set; }
        public double IndirimOrani { get; set; }
        public bool SatisDurum { get; set; }

        //Ref
        public int SanatciId { get; set; }

        //Navigator property
        public virtual Sanatci Sanatci { get; set; }
    }
}
