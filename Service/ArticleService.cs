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

         public async Task<IEnumerable< Article>> GetArticlesByUserId(int userId)
         {
            var res= await  _ghumakkadContext.Articles.Where(x=>x.CreatedBy==userId).ToListAsync();
             
            return res;
         }

          public async  Task<int> DeleteArticle(int id)
          {
            Article article= await _ghumakkadContext.Articles.FirstOrDefaultAsync(x=>x.ArticleId==id);
             _ghumakkadContext.Articles.Remove(article);
             var res=await _ghumakkadContext.SaveChangesAsync();
           return res;
          }
              

              public async  Task<int> DisableArticleByArticleId(int id)
          {
            Article article= await _ghumakkadContext.Articles.FirstOrDefaultAsync(x=>x.ArticleId==id);
             if(article!=null)
            { article.IsActive=0;
                 _ghumakkadContext.Attach(article);
            _ghumakkadContext.Entry(article).Property(p => p.IsActive).IsModified = true;
            
             var res=await _ghumakkadContext.SaveChangesAsync();
           return res;
            }
            return 0;
           
          }

             public async  Task<int> EnableArticleByArticleId(int id)
          {
            Article article= await _ghumakkadContext.Articles.FirstOrDefaultAsync(x=>x.ArticleId==id);
             if(article!=null)
            { article.IsActive=1;
                 _ghumakkadContext.Attach(article);
            _ghumakkadContext.Entry(article).Property(p => p.IsActive).IsModified = true;
            
             var res=await _ghumakkadContext.SaveChangesAsync();
           return res;
            }
            return 0;
          }


         public async Task<IEnumerable< Article>> GetAllArticles()
         {
            return await _ghumakkadContext.Articles.ToListAsync();
         }
    }
}