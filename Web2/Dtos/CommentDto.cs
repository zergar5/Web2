using System.Runtime.InteropServices.JavaScript;
using Web2.Models;

namespace Web2.Dtos;

public class CommentDto
{
    public string NickName { get; set; } = null!;
    public string Comment { get; set; } = null!; 
    public DateTime TimeOfCreation { get; set; }

    public static explicit operator CommentDto(Comment comment)
    {
        return new CommentDto
        {
            NickName = comment.NickName,
            Comment = comment.Text,
            TimeOfCreation = comment.TimeOfCreation
        };
    }
}