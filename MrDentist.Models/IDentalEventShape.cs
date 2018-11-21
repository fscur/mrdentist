namespace MrDentist.Models
{
    public interface IDentalEventShape
    {
        int Id { get; set; }
        IPointF Position { get; set; }
        System.Drawing.Color Color { get; set; }
    }
}