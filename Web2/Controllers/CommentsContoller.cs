using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web2.Dtos;
using Web2.Models;
using Web2.Services;

namespace Web2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CommentsController : Controller
    {
        private readonly CommentsService _commentsService;

        public CommentsController(CommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [HttpPost]
        [ActionName("comment")]
        public async Task<IActionResult> PostComment(string nickName, string text)
        {
            var comment = await _commentsService.Add(nickName, text);
            return Ok(comment);
        }

        [HttpGet]
        [ActionName("comments")]
        public IActionResult GetAllComments()
        {
            return Ok(_commentsService.GetAll().Select(c => (CommentDto)c));
        }
    }
}
