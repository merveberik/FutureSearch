using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TarotCardManager : ITarotCardService
    {
        ITarotCardDal _tarotCardDal;
        public TarotCardManager(ITarotCardDal tarotCardDal)
        {
            _tarotCardDal = tarotCardDal;
        }
        public IResult Add(TarotCard tarotCard)
        {
            _tarotCardDal.Add(tarotCard);
            return new SuccessResult(Messages.TarotCardAdded);
        }

        public IDataResult<List<TarotCard>> GetAll()
        {
            return new SuccessDataResult<List<TarotCard>>(_tarotCardDal.GetAll());

        }

        public IDataResult<TarotCard> GetById(int id)
        {
            return new SuccessDataResult<TarotCard>(_tarotCardDal.Get(c => c.CardId == id));
        }

        public IResult Update(TarotCard tarotCard)
        {
            _tarotCardDal.Update(tarotCard);
            return new SuccessResult(Messages.TarotCardUpdated);
        }
    }
}
