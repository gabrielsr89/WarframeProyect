using System;
using System.Collections.Generic;

namespace WfBD.Models;

public partial class Tier
{
    public int TierId { get; set; }

    public string Tier1 { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<ResourcesZoneObject> ResourcesZoneObjects { get; set; } = new List<ResourcesZoneObject>();
}
