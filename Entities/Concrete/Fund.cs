using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Fund:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FundName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}