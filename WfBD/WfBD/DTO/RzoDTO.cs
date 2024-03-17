using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfBD.Models;

namespace WfBD.DTO
{
    public class RzoDTO
    {
        public int resourcesZoneObject { get; set; }

        public int? ResourceId { get; set; }

        public int? ZoneId { get; set; }

        public int? TierId { get; set; }

        public string? Description { get; set; }

        public virtual Resource? Resource { get; set; }

        public virtual Tier? Tier { get; set; }

        public virtual ZoneDTO? Zone { get; set; }
    }
}
