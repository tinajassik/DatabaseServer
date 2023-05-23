﻿using Domain.DTOs;
using Domain.Models;

namespace EfcDataAccess.DaoInterfaces;

public interface IPrivateFileDao
{
    Task<PrivateFile> CreateAsync(PrivateFileCreationDto file);
}