using Microsoft.AspNetCore.Mvc;
using REST_API.Services;

namespace REST_API.Controllers;


[ApiController]
[Route("api/students")]
public class StudentsController : ControllerBase
{
    private readonly IDbService _dbService;

    public StudentsController(IDbService dbService)
    {
        this._dbService = dbService;
    }
}