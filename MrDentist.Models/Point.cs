namespace MrDentist.Models
{
    public class Point : IDentalIssueShape
    {
        public int Id { get; set; }
        public System.Drawing.Color Color { get; set; }
        public IPointF Position { get; set; }
        public System.Drawing.SizeF Size { get; set; }
    }
}
