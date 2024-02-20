namespace BookApp.Models;

public class Author {
    //props

    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }

    // author can have a list of books i.e. 1:N relation
    public List<Book>? Books {get; set;} 
}