using LandcareResearch.Models;

namespace LandcareResearch.Services;

public static class NewsService
{
    static List<News> News { get; }
    static int nextId = 3;
    static NewsService()
    {
        News = new List<News>
        {
            new News 
            { 
                Id = 1, 
                Title = "Amazon Sale Offers on Google Pixel 7 Pro, OnePlus Nord 2T, iQOO Neo 6, And Other Smartphones", 
                Description = "Amazon Sale Offers: It's time to upgrade your smartphone with this top-notch mobile phone during the Amazon sale offers. Get up to 40% off on top brands like Google Pixel, OnePlus Nord, and more.",
                Content = "Amazon Sale Offers: The new-age smartphones are loaded with multiple features like high-performing cameras, a better chipset for a faster processor, and huge battery life for nonstop working or gaming. The Amazon sale is here and you have the option ... [2507 chars]",
                Url = "https://english.jagran.com/top-deals/today-deals/amazon-deals/amazon-sale-offers-on-google-pixel-7-pro-oneplus-nord-2t-iqoo-neo-6-and-other-smartphones-10055805",
                Image = "https://imgeng.jagran.com/images/2022/nov/best smartphones1669786156691.jpg",
                PublishedAt = "2022-11-30T05:28:23Z",
                Source = new Source("Jagran English", "https://english.jagran.com"),
            },
            new News 
            { 
                Id = 2, 
                Title = "Perranporth chip shop owner destroys negative reviewers in Google rampage", 
                Description = "Andy Coutts branded some critics \"pathetic\" and \"self-entitled\"",
                Content = "The owner at a Cornish chippy has gone on the offensive against negative reviewers, calling them everything from “pathetic” to “ridiculous”. Pickwicks Fish & Chips in Perranporth has an average of 3.4 out of 5 from 534 Google reviews, but over recent... [4391 chars]",
                Url = "https://www.cornwalllive.com/news/cornwall-news/perranporth-chip-shop-owner-destroys-7875711",
                Image = "https://i2-prod.cornwalllive.com/incoming/article7875734.ece/ALTERNATES/s1200/0_pickwicksJPG.jpg",
                PublishedAt = "2022-11-30T05:00:00Z",
                Source = new Source("Cornwall Live", "https://www.cornwalllive.com"),
            },
        };
    }

    public static List<News> GetAll() => News;

    public static News? Get(int id) => News.FirstOrDefault(news => news.Id == id);

    public static void Add(News news)
    {
        news.Id = nextId++;
        News.Add(news);
    }

    public static void Delete(int id)
    {
        var news = Get(id);
        if(news is null)
            return;

        News.Remove(news);
    }

    public static void Update(News news)
    {
        var index = News.FindIndex(n => n.Id == news.Id);
        if(index == -1)
            return;

        News[index] = news;
    }
}