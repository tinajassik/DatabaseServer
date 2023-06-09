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
    public Category Category { get; set; }
    public string ContentType { get; set; }
    public User UploadedBy { get;  set; }
    // [NotMapped][JsonIgnore]
    // public IBrowserFile? file { get; set; }
    public byte[] bytes{ get; set; }


    public File(User uploadedBy, string description)
    {
        this.UploadedBy = uploadedBy;
        Description = description;
    }

    public File()
    {
    }
    
    public File(string title, string description, Category category, User uploadedBy, byte[] bytes, string contentType)
    {
        Title = title;
        Description = description; 
        Category = category;
        UploadedBy = uploadedBy;
        this.bytes = bytes;
        ContentType = contentType;
    }
    

    // public byte[] GetBytesFromIBrowserFile(IBrowserFile file)
    // {
    //     using (var stream = new MemoryStream())
    //     {
    //         file.OpenReadStream().CopyTo(stream);
    //         return stream.ToArray();
    //     }
    // }










}