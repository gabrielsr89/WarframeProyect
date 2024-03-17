using System;
using System.Collections.Generic;

namespace WfBD.Models;

public partial class Resource
{
    public int ResourceId { get; set; }

    public string Resource1 { get; set; } = null!;

    public virtual ICollection<ResourcesZoneObject> ResourcesZoneObjects { get; set; } = new List<ResourcesZoneObject>();
}
