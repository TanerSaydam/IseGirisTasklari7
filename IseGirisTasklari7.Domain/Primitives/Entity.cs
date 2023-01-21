﻿namespace IseGirisTasklari7.Domain.Primitives;

public abstract class Entity
{
    public string Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

}
