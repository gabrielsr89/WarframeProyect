using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfBD.DTO
{
    public class ZoneDTO
    {
        public int ZoneId { get; set; }

        public string zone { get; set; } = null!;

        public string? Description { get; set; }
    }
}
