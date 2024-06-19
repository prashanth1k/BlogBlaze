using System;

namespace BlogBlaze.Models
{
  public class Post
  {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime PublishedDate { get; set; }
    public DateTime LastRevisedDate { get; set; }
    public string? Author { get; set; }
    public string? Category { get; set; }
    public string? UrlSlug { get; set; }
  }
}