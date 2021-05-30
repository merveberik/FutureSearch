using Business.Abstract;
using Business.Constant;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TarotImageManager : ITarotImageService
    {
        ITarotImageDal _tarotImageDal;

        public TarotImageManager(ITarotImageDal tarotImageDal)
        {
            _tarotImageDal = tarotImageDal;
        }

        public IResult Add(IFormFile file, TarotImage tarotImage)
        {

            tarotImage.ImagePath = FileHelper.Add(file);
            _tarotImageDal.Add(tarotImage);
            return new SuccessResult();
        }

        public IDataResult<List<TarotImage>> GetAll()
        {
            return new SuccessDataResult<List<TarotImage>>(_tarotImageDal.GetAll());
        }

        public IDataResult<List<TarotImage>> GetByCardNum(int CardNum)
        {
            var result = _tarotImageDal.GetAll(c => c.CardNum == CardNum);

            if (result != null)
            {
                return new ErrorDataResult<List<TarotImage>>(Messages.FileNotFound);
            }

            return new SuccessDataResult<List<TarotImage>>(CheckIfImageNull(CardNum).Data);
        }

        private IDataResult<List<TarotImage>> CheckIfImageNull(int cardNum)
        {
            try
            {
                string path = @"..\WebAPI\wwwroot\Images\default.jpg";

                var result = _tarotImageDal.GetAll(c => c.CardNum == cardNum).Any();

                if (!result)
                {
                    List<TarotImage> tarotImage = new List<TarotImage>();

                    tarotImage.Add(new TarotImage { CardNum = cardNum, ImagePath = path });

                    return new SuccessDataResult<List<TarotImage>>(tarotImage);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<TarotImage>>(exception.Message);
            }

            return new SuccessDataResult<List<TarotImage>>(_tarotImageDal.GetAll(c => c.CardNum == cardNum));
        }
    }
}
