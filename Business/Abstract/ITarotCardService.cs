using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITarotCardService
    {
        IDataResult<List<TarotCard>> GetAll();
        IDataResult<TarotCard> GetById(int id);
        IResult Add(TarotCard tarotCard);
        IResult Update(TarotCard tarotCard);
    }
}
