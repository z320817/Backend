namespace LandcareResearch.Models;

public class News
{
    [field:NonSerialized]
    public int? Id { get; set; }
    public string? Title { get; set; } 
    public string? Description { get; set; }

    public string? Content { get; set; }

    public string? Url { get; set; }

    public string? Image { get; set; }

    public string? PublishedAt { get; set; }

    public Source? Source { get; set; }
}

public class Source : News
{
    public Source(string name, string url)
    {
        Name = name;
        SourceUrl = url;
    }
    public string? Name { get; set; }
    public string? SourceUrl { get; set; }

}