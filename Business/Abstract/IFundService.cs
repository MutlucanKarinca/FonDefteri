using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFundService
    {
        IDataResult<List<Fund>> GetFundsByUserId(int userId);
        IResult Add(Fund fund);
        IResult Delete(Fund fund);
        IResult Update(Fund fund);
    }
}