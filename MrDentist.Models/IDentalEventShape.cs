namespace MrDentist.Models
{
    public interface IDentalIssueShape
    {
        int Id { get; set; }
        IPointF Position { get; set; }
        System.Drawing.Color Color { get; set; }
    }
}