using LandcareResearch.Models;
using LandcareResearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace LandcareResearch.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    public NewsController()
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<Article>?>> Get() => await NewsService.GetArticles();
    
    [HttpGet("search/{term}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<List<Article>?>> Search(string term) => await NewsService.GetArticles(term);
}