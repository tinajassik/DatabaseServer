﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    // public string? Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Username { get; set; }
    public string Name{ get; set; }
    public bool isAdmin { get; set; }

    [JsonIgnore]
    public List<PrivateFile>? SharedWithMe { get; set; }
    // [JsonIgnore]
    // public ICollection<File> Files { get; set; }
}