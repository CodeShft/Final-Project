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
    public class ImageValidation:AbstractValidator<Image>

    {
        IImageDAL IImageDAL;
        public ImageValidation(IImageDAL dAL)
        {
            RuleFor(c => c.PostID).NotNull().WithMessage("Oyun Id Alanı Boş Geçilemez!");
            RuleFor(c => c.ImageURL).NotNull().WithMessage("Fotograf Url Alanı Boş Geçilemez!");

            IImageDAL = dAL;
        } 





    }
}
