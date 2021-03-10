using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFundDal:EfEntityRepositoryBase<Fund,FonDefteriContext>,IFundDal
    {
        
    }
}