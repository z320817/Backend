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

    [HttpGet("{id}")]
    public ActionResult<News> Get(int id)
    {
        var news = NewsService.Get(id);

        if(news == null)
            return NotFound();

        return news;
    }

    // POST action

    // PUT action

    // DELETE action
}