namespace HallBudgetPro.Models
{
    public interface IHallDAO
    {
        List<Hall> GetHallDetails(int price);
    }
}
