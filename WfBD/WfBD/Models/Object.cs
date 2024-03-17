using System;
using System.Collections.Generic;

namespace WfBD.Models;

public partial class Object
{
    public int ObjectId { get; set; }

    public string Object1 { get; set; } = null!;

    public int TypeObjectId { get; set; }

    public bool? Vault { get; set; }

    public virtual TypeObject TypeObject { get; set; } = null!;
}
