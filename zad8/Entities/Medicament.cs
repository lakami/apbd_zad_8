﻿using System.ComponentModel.DataAnnotations;

namespace zad8;

public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    
    [Required]
    [MaxLength(100)]
    public string Description { get; set; } = null!;
    
    [Required]
    [MaxLength(100)]
    public string Type { get; set; } = null!;
}