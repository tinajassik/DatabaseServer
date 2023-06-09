﻿


using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserDao userDao;

    public UsersController(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    [HttpPost]
    [Route("createUser")]
    public async Task<ActionResult<User>> CreateAsync(User user)
    {
        try
        {
            User newUser = await userDao.CreateAsync(user);
            return Created($"/users/{user.Id}", newUser);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    [Route("{username}")]
    public async Task<ActionResult<User?>> GetByUsernameAsync(string username)
    {
        try
        {
            User? user = await userDao.GetByUsernameAsync(username);
            return Ok(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    [Route("getAll")]
    public async Task<ActionResult<List<UserDisplayDto>>> GetAllAsync()
    {

        try
        {
            List<UserDisplayDto> result = await userDao.GetAll();
            return Ok(result);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("login/{username}.{password}")]
    public async Task<ActionResult<User?>> LoginAsync(string username, string password)
    {
        try
        {
            UserLoginDto userLoginDto = new UserLoginDto(username, password);
            User? user = await userDao.LoginAsync(userLoginDto);
            return Ok(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}