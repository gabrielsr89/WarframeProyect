using System;
using System.Collections.Generic;

namespace WfBD.Models;

public partial class ResourcesZoneObject
{
    public int ResourcesZoneObject1 { get; set; }

    public int? ResourceId { get; set; }

    public int? ZoneId { get; set; }

    public int? TierId { get; set; }

    public string? Description { get; set; }

    public virtual Resource? Resource { get; set; }

    public virtual Tier? Tier { get; set; }

    public virtual Zone? Zone { get; set; }
}
