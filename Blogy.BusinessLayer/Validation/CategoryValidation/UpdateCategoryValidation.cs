using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Validation.CategoryValidation
{
    public class UpdateCategoryValidation : AbstractValidator<Category>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçmeyiniz").MinimumLength(3).WithMessage("Lütfen kategori adını en az 3 karakter olarak giriniz").MaximumLength(30).WithMessage("Lütfen kategori adını en fazla 30 karakter olarak giriniz").Equal("a").WithMessage("Lütfen kategori adına a harfi ekleyiniz");
        }
    }
}
