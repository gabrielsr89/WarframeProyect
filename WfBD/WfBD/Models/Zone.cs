using System;
using System.Collections.Generic;

namespace WfBD.Models;

public partial class Zone
{
    public int ZoneId { get; set; }

    public string Zone1 { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<ResourcesZoneObject> ResourcesZoneObjects { get; set; } = new List<ResourcesZoneObject>();
}
