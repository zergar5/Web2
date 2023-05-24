using Web2.Models;

namespace Web2.Services;

public class CommentsService
{
    private readonly CommentsContext _context;

    public CommentsService(CommentsContext context)
    {
        _context = context;
    }

    public async Task<Comment> Add(string nickName, string text)
    {
        var comment = new Comment
        {
            NickName = nickName,
            Text = text,
            TimeOfCreation = DateTime.UtcNow
        };

        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    public IEnumerable<Comment> GetAll()
    {
        return _context.Comments.AsEnumerable();
    }
}