#nullable enable
using System;
using System.ComponentModel.DataAnnotations;

namespace BallanceRecordApi.Domain;

public class Level
{
    [Key]
    public string Hash { get; set; }
    public string? Name { get; set; }
    public bool IsCustom { get; set; }
    public string? Author { get; set; }
    public string? Difficulty { get; set; }
    public string? Remark { get; set; }
}