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
    }
}