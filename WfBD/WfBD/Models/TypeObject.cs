using System;
using System.Collections.Generic;

namespace WfBD.Models;

public partial class TypeObject
{
    public int TypeObjectId { get; set; }

    public string TypeObject1 { get; set; } = null!;

    public virtual ICollection<Object> Objects { get; set; } = new List<Object>();
}
