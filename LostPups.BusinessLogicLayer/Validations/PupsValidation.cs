
using FluentValidation;
using LostPups.DataAccess.Abstract;
using LostPups.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.BusinessLogicLayer.Validations
{
    public class PupsValidation:AbstractValidator<Pups>
    {
        IPupsDAL dAL;
        public PupsValidation (IPupsDAL pupsDAL) 
        {
            RuleFor(x => x.PostName).NotNull().WithMessage("İlan adı boş geçilemez!");
            RuleFor(x => x.PupsName).MaximumLength(1).MaximumLength(100).WithMessage("Hayvan isimleri 1-100");
            RuleFor(x => x.PupsName).NotNull().WithMessage("İsim Alanı boş geçilemez!");
            RuleFor(x => x.Publisher).NotNull().WithMessage("Açıklama Alanı Boş Geçilemez!");
            RuleFor(x => x.PostDesc).NotNull().WithMessage("Gönderme Tanımı boş geçilemez!");
            RuleFor(x => x.Location).NotNull().WithMessage("Kaybolma konumu boş geçilemez!");
            RuleFor(x=>x.AdStatus).NotNull().WithMessage("İlan durumu boş geçilemez!");
            RuleFor(x =>x.AdUrgency).NotNull().WithMessage("İlan Aciliyet durumu boş geçilemez");
            RuleFor(x => x.Breed).NotNull().WithMessage("Cins boş geçilemez");
            RuleFor(x=>x.PhysicalCharacteristics).NotNull().WithMessage("Fiziksel Özellikleri Boş Geçilemez!");
            RuleFor(x=>x.LeashFeatures).NotNull().WithMessage("Tasma Alanı Boş Geçilemez!");
            dAL = pupsDAL;
        }

         
    }
}
