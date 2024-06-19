using Bogus;
using BlogBlaze.Models;
using System.Linq;
using BlogBlaze.Data;

public class PostSeeder
{
  private readonly AppDbContext _dbContext;

  public PostSeeder(AppDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public void Seed()
  {
    if (!_dbContext.Posts.Any()) // only seed if empty
    {
      var faker = new Faker<Post>()
          .RuleFor(p => p.Title, f => f.Lorem.Sentence())
          .RuleFor(p => p.Content, f => f.Lorem.Paragraphs())
          .RuleFor(p => p.UrlSlug, f => f.Lorem.Slug())
          .RuleFor(p => p.Author, f => f.Name.FullName())
          .RuleFor(p => p.PublishedDate, f => f.Date.Past());

      var posts = faker.Generate(50);

      _dbContext.Posts.AddRange(posts);
      _dbContext.SaveChanges();
    }
  }
}