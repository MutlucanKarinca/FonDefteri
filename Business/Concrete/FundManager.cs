using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FundManager : IFundService
    {
        IFundDal _fundDal;

        public FundManager(IFundDal fundDal)
        {
            _fundDal = fundDal;
        }


        public IDataResult<List<Fund>> GetFundsByUserId(int userId)
        {
            return new SuccessDataResult<List<Fund>>(_fundDal.GetAll(x=>x.UserId==userId));
        }

        [ValidationAspect(typeof(FundValidator))]
        public IResult Add(Fund fund)
        {
            _fundDal.Add(fund);
            return new SuccessResult(Messages.FundAdded);
        }

        public IResult Delete(Fund fund)
        {
            try
            {
                _fundDal.Delete(fund);
                return new SuccessResult(Messages.FundDeleted);
            }
            catch (ArgumentException)
            {
                return new ErrorResult(Messages.FundIdInvalid);
            }

        }

        [ValidationAspect(typeof(FundValidator))]
        public IResult Update(Fund fund)
        {
            _fundDal.Update(fund);
            return new SuccessResult(Messages.FundUpdated);
        }
    }
}