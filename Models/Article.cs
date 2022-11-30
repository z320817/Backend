namespace LandcareResearch.Models;

public class Article
{
    [field:NonSerialized]
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }

    public string? Content { get; set; }

    public string? Url { get; set; }

    public string? Image { get; set; }

    public string? PublishedAt { get; set; }

    public class Source 
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
