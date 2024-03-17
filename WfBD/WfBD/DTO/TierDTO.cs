using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfBD.DTO
{
    public class TierDTO
    {
        public int TierId { get; set; }

        public string tier { get; set; } = null!;

        public string? Description { get; set; }
    }
}
