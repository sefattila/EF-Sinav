using Sinav.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Core.Entities
{
    public class Sanatci : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual IList<Album> Albums { get; set; }

    }
}
