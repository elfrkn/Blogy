using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
		public List<Article> TGetArticleWithWriter();
        Writer TGetWriterInfoByArticleWriter(int id);

        List<Article> TGetArticlesByWriterAndCategory(int id);

        Article TGetArticleByIdWithWriterIdAndCategory(int id);
        List<Article> TGetOtherBlogPostByWriter(int id);

        List<Article> TGetLast4BlogPost();
        
        public List<Article> TGetArticleFilterList(string search);


    }
}
