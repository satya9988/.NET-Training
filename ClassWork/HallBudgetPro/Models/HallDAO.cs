using System.Collections.Generic;
using System.Linq;

namespace HallBudgetPro.Models
{
    public class HallDAO : IHallDAO
    {
        private readonly HallDBContext _ctx;

        public HallDAO(HallDBContext ctx)
        {
            _ctx = ctx;
        }

        public List<Hall> GetHallDetails(int price)
        {
            return _ctx.Hall.Where(h => h.CostPerDay <= price).ToList();
        }
    }
}
