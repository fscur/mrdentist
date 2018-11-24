namespace MrDentist.Models
{
    public class Restoration : IDentalIssue
    {
        private Point shape;

        public int Id { get; private set; }
        public IDentalIssueShape Shape { get { return shape; } }

        public Restoration(int id, IPointF position)
        {
            Id = id;
            shape = new Point()
            {
                Id = id,
                Color = System.Drawing.Color.Cyan,
                Position = position,
                Size = new System.Drawing.SizeF(8.0f, 8.0f)
            };
        }
    }
}
