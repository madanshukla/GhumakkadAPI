using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GhumakkadAPI.Database;
using GhumakkadAPI.Models;
using GhumakkadAPI.Service;

namespace GhumakkadAPI.Manager
{
   
    public class ArticleManager :IArticleManager
    {  
         private readonly IArticleService _articleService;
    public ArticleManager(IArticleService articleService)
    {
        _articleService=articleService;
    }
           public async Task<int> PostArticles(ArticleEntity articleEntity)
          {
            Article article=MapArticle(articleEntity);
            if(article!=null)
            {
                
           return await _articleService.PostArticles(article);
            }else return default;

          }

           public async Task<Article> GetArticles(int id)
          {
            return await _articleService.GetArticles(id);
          }

public async Task<IEnumerable< Article>> GetArticlesByUserId(int userId)
{
return await _articleService.GetArticlesByUserId(userId);
}

public async  Task<int> DeleteArticle(int id)
{
  return await _articleService.DeleteArticle(id);
}
          private Article MapArticle(ArticleEntity articleEntity)
          {
            return new Article()
            {
                Title=articleEntity.Title, 
                Description=articleEntity.Description,
                 CreatedBy=articleEntity.CreatedBy,
                  CreatedDate=articleEntity.CreatedDate,
                   IsActive=articleEntity.IsActive,
                    State=articleEntity.State,
                     UpdatedBy=articleEntity.UpdatedBy,
                      UpdatedDate=articleEntity.UpdatedDate
            };
          }

        public async Task<int> DisableArticleByArticleId(int id)
        {
           return await _articleService.DisableArticleByArticleId(id);
        }

        public async Task<int> EnableArticleByArticleId(int id)
        {
            return await _articleService.EnableArticleByArticleId(id);
        }

         public async Task<IEnumerable< Article>> GetAllArticles()
         {
            return await  _articleService.GetAllArticles();
         }
    }
}