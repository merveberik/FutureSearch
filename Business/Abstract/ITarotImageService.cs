using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITarotImageService
    {
        IDataResult<List<TarotImage>> GetAll();
        IDataResult<List<TarotImage>> GetByCardNum(int CardNum);
        IResult Add(IFormFile file, TarotImage tarotImage);
    }
}
