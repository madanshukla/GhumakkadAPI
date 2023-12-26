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
    }
}