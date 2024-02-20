namespace BookApp.Models;

public class Book{
    //prop
    public int Id { get; set; }
    public string? Name { get; set; }
    public int AuthorId { get; set; }
    
    public Author? Author {get;set;}

}