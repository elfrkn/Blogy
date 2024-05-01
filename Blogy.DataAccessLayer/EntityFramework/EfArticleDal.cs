using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Blogy.DataAccessLayer.EntityFramework
{
	public class EfArticleDal : GenericRepository<Article>, IArticleDal
	{
		BlogyContext context = new BlogyContext();

        public Article GetArticleByIdWithWriterIdAndCategory(int id)
        {
            var values = context.Articles.Where(x => x.ArticleId == id).Include(x => x.Category).Include(x => x.Writer).FirstOrDefault();
            return values;
        }

 

        public List<Article> GetArticleFilterList(string search)
        {
            var values = context.Articles.Where(x => x.Title.Contains(search)).Include(x=>x.Writer).ToList();
            return values;
        }

        public List<Article> GetArticlesByWriterAndCategory(int id)
        {
            var values = context.Articles.Where(x => x.AppUserId == id).Include(x=>x.Category).ToList();
            return values;
        }

        public List<Article> GetArticleWithWriter()
		{
			var values = context.Articles.Include(x => x.Writer).ToList();
			return values;
		}

        public List<Article> GetCategoryName(int id)
        {
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> GetLast4BlogPost()
        {
            var values = context.Articles.OrderByDescending(y => y.CreatedDate).Take(4).ToList();
            return values;
        }

        public List<Article> GetOtherBlogPostByWriter(int id)
        {
            var values = context.Articles.Where(x => x.AppUserId == id).Include(x => x.Writer).Take(3).ToList();
            return values;
        }

        public Writer GetWriterInfoByArticleWriter(int id)
        {
			var values = context.Articles.Where(x => x.ArticleId == id).Select(y => y.Writer).FirstOrDefault();
			return values;
        }

      
    }
}
