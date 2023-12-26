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

         [HttpGet("GetArticles")]//Good Practice
        public async Task<IActionResult> GetEmployeeDetails(int articleId)// Function never appears as Url
        {
           return Ok(await _articleManager.GetArticles(articleId));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

          [HttpPost("PostArticles")]//Good Practice
        public async Task<IActionResult> AddArticles(ArticleEntity articleEntity)// Function never appears as Url
        {
            return Ok(await _articleManager.PostArticles(articleEntity));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

         [HttpDelete("DeleteEmployee")]//Good Practice
        public IActionResult DeleteEmployee(int id)// Function never appears as Url
        {
            return Ok(_articleManager.GetArticles(1));//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }

        [HttpGet("SearchEmployee")]//Good Practice
        public IActionResult SearchEmployee(int id)// Function never appears as Url
        {
            return Ok();//Ok,NotFound,BadResult,BadRequest inbuilt classes implementing IactionResult Interface
        }
    }
}