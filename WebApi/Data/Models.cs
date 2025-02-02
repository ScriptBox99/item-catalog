﻿using System;

namespace WebApi.Data;

public class Item : AuditableEntity, ISoftDelete
{
    public Item()
    {

    }

    public Item(string id, string name, string? description = null)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; } = null!;
    public string? Image { get; set; } = null!;


    public DateTime? Deleted { get; set; }
    public string? DeletedBy { get; set; }
}

