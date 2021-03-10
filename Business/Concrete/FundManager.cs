using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FundManager:IFundService
    {
        IFundDal _fundDal;

        public FundManager(IFundDal fundDal)
        {
            _fundDal = fundDal;
        }


        public IDataResult<List<Fund>> GetFundsByUserId()
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(Fund fund)
        {
            _fundDal.Add(fund);
            return new SuccessResult(Messages.FundAdded);
        }

        public IResult Delete(Fund fund)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Fund fund)
        {
            throw new System.NotImplementedException();
        }
    }
}