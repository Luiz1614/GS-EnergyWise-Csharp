﻿using System.ComponentModel.DataAnnotations;

namespace GS_EnergyWise.Domain.Entities;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}