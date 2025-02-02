﻿namespace WebApi.Data;

public abstract class AuditableEntity
{
    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
