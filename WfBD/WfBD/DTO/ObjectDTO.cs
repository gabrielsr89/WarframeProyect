using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfBD.DTO
{
    public class ObjectDTO
    {
        public int ObjectId { get; set; }

        public string pObject { get; set; } = null!;

        public int TypeObjectId { get; set; }

        public bool? Vault { get; set; }

    }
}
