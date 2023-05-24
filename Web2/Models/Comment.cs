namespace Web2.Models;

public class Comment
{
    public int Id { get; set; }
    public string NickName { get; set; } = null!;
    public string Text { get; set; } = null!;
    public DateTime TimeOfCreation { get; set; }
}