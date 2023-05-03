﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Forms;

namespace Domain.Models;

public class File
{
    
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
    public string Category { get; set; }
    [AllowNull]
    public User? uploadedBy { get; set; }
    // [NotMapped][JsonIgnore]
    // public IBrowserFile? file { get; set; }
    public byte[] bytes{ get; set; }


    // public byte[] GetBytesFromIBrowserFile(IBrowserFile file)
    // {
    //     using (var stream = new MemoryStream())
    //     {
    //         file.OpenReadStream().CopyTo(stream);
    //         return stream.ToArray();
    //     }
    // }










}