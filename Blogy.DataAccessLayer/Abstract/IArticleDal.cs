using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> GetArticleWithWriter();
        Writer GetWriterInfoByArticleWriter(int id);
        List<Article> GetArticlesByWriterAndCategory(int id);
        Article GetArticleByIdWithWriterIdAndCategory(int id);
        List<Article> GetOtherBlogPostByWriter(int id);

        List<Article> GetLast4BlogPost();
        List<Article> GetArticleFilterList(string search);


    }
}
