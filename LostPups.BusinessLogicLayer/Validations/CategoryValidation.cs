using FluentValidation;
using LostPups.DataAccess.Abstract;
using LostPups.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.BusinessLogicLayer.Validations
{
    public class CategoryValidation:AbstractValidator<Category>

    {
        ICategoryDAL categoryDAL;
        public CategoryValidation(ICategoryDAL dAL)
        {
            RuleFor(s => s.CategoryName).Length(1, 100).WithMessage("Kategori İsmi 1-100 Karakter arasında olmalı!");
            RuleFor(s => s.CategoryName).NotNull().WithMessage("Kategori ismi boş geçilemez!");
            categoryDAL = dAL;
        }


    }
}
