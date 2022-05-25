using DemoSignalR.Domain;
using DemoSignalR.Hubs;
using DemoSignalR.Models;
using DemoSignalR.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private DataContext _dc;
        private ArticleHub _hub;

        public ArticleController(DataContext dc, ArticleHub hub)
        {
            _dc = dc;
            _hub = hub;
        }

        [HttpPost]
        public async Task<IActionResult> Ajout(ArticleForm newArticle)
        {
            _dc.Articles.Add(newArticle.toArticle());
            _dc.SaveChanges();
            _hub.NotifierAddAricle();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_dc.Articles);
        }
    }
}
