using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using GhumakkadAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace GhumakkadAPI.Service
{
    public class ArticleService :IArticleService
    {
        private readonly GhumakkadContext _ghumakkadContext;
        public ArticleService(GhumakkadContext ghumakkadContext)
        {
            _ghumakkadContext=ghumakkadContext;
        }
         public async Task<int> PostArticles(Article article)
         {
           await _ghumakkadContext.Articles.AddAsync(article);
             var res=await _ghumakkadContext.SaveChangesAsync();
            return res;
         }

         public async Task<Article> GetArticles(int id)
         {
         var res=  await _ghumakkadContext.Articles.FirstOrDefaultAsync(x=>x.ArticleId==id);
             
            return res;
         }
    }
}