using LandcareResearch.Models;
using LandcareResearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace LandcareResearch.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsController : ControllerBase
{
    public NewsController()
    {
    }

    [HttpGet]
    public ActionResult<List<News>> GetAll() =>
        NewsService.GetAll();

    [HttpGet("{id:int}")]
    public ActionResult<News> Get(int id)
    {
        var news = NewsService.Get(id);

        if(news == null)
            return NotFound();

        return news;
    }
    
    [HttpGet("find/{term}")]
    public ActionResult<News> Get(string term)
    {
        var news = NewsService.Search(term);

        if(news == null)
            return NotFound();

        return news;
    }
}