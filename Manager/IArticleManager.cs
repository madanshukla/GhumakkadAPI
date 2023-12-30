using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GhumakkadAPI.Database;
using GhumakkadAPI.Models;

namespace GhumakkadAPI.Manager
{
    public interface IArticleManager
    {
          Task<int> PostArticles(ArticleEntity article);

           Task<Article> GetArticles(int id);

           Task<IEnumerable< Article>> GetArticlesByUserId(int userId);

           Task<int> DeleteArticle(int id);

            Task<int> DisableArticleByArticleId(int id);

              Task<int> EnableArticleByArticleId(int id);

              Task<IEnumerable< Article>> GetAllArticles();
    }
}