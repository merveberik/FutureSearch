using Business.Abstract;
using Business.Constant;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{ 
    public class CardDescriptionManager : ICardDescriptionService
    {
        ICardDescriptionDal _cardDescriptionDal;
        public CardDescriptionManager(ICardDescriptionDal cardDescriptionDal)
        {
            _cardDescriptionDal = cardDescriptionDal;
        }
        public IResult Add(CardDescription cardDescription)
        {

            _cardDescriptionDal.Add(cardDescription);
            return new SuccessResult(Messages.CardDescriptionAdded);
        }
        public IDataResult<List<CardDescription>> GetAll()
        {
            return new SuccessDataResult<List<CardDescription>>(_cardDescriptionDal.GetAll());
        }

        public IDataResult<CardDescription> GetById(int id)
        {
            return new SuccessDataResult<CardDescription>(_cardDescriptionDal.Get(c => c.CardId == id));
        }

        public IResult Update(CardDescription cardDescription)
        {
            _cardDescriptionDal.Update(cardDescription);
            return new SuccessResult(Messages.CardDescriptionAdded);
        }
    }
}
