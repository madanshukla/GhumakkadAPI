using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GhumakkadAPI.Manager;
using GhumakkadAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GhumakkadAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleManager _articleManager;
        public ArticleController(IArticleManager articleManager)
        {
            _articleManager=articleManager;
        }

         [HttpGet("GetArticlesByArticleId")]//Good Practice
        public async Task<IActionResult> GetArticles(int articleId)// Function never appears as Url
        {
           return Ok(await _articleManager.GetArticles(articleId));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

        [HttpGet("GetArticlesByUserId")]//Good Practice
        public async Task<IActionResult> GetArticlesByUserId(int userId)// Function never appears as Url
        {
           return Ok(await _articleManager.GetArticlesByUserId(userId));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

          [HttpPost("PostArticles")]//Good Practice
        public async Task<IActionResult> AddArticles(ArticleEntity articleEntity)// Function never appears as Url
        {
            return Ok(await _articleManager.PostArticles(articleEntity));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

         [HttpDelete("DeleteArticle")]//Good Practice
        public async Task<IActionResult>  DeleteArticle(int id)// Function never appears as Url
        {
            return Ok(await _articleManager.DeleteArticle(id));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

        [HttpPost("DisableArticleByArticleId")]//Good Practice
        public async Task<IActionResult> DisableArticleByArticleId(int id)// Function never appears as Url
        {
            return Ok(await _articleManager.DisableArticleByArticleId(id));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

        [HttpPost("EnableArticleByArticleId")]//Good Practice
        public async Task<IActionResult> EnableArticleByArticleId(int id)// Function never appears as Url
        {
            return Ok(await _articleManager.EnableArticleByArticleId(id));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

        [HttpGet("SearchEmployee")]//Good Practice
        public IActionResult SearchEmployee(int id)// Function never appears as Url
        {
            return Ok();//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }
    }
}