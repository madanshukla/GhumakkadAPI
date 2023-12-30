using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GhumakkadAPI.Database;

namespace GhumakkadAPI.Service
{
    public interface IArticleService
    {
            Task<int> PostArticles(Article article);

           Task<Article> GetArticles(int id);

           Task<IEnumerable< Article>> GetArticlesByUserId(int userId);

            Task<int> DeleteArticle(int id);

              Task<int> DisableArticleByArticleId(int id);

              Task<int> EnableArticleByArticleId(int id);

                 Task<IEnumerable< Article>> GetAllArticles();



    }
}