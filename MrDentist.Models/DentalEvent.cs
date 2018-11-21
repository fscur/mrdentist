namespace MrDentist.Models
{
    public interface IDentalEvent
    {
        int Id { get; }
        IDentalEventShape Shape { get; }
    }
}