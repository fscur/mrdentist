namespace MrDentist.Models
{
    public class Cavity : IDentalIssue
    {
        private Point shape;

        public int Id { get; private set; }
        public IDentalIssueShape Shape { get { return shape; }}

        public OdontogramEntry Entry { get; private set; }

        public Cavity(int id, IPointF position)
        {
            Id = id;
            shape = new Point()
            {
                Id = id,
                Color = System.Drawing.Color.Red,
                Position = position,
                Size = new System.Drawing.SizeF(8.0f, 8.0f)
            };
        }
    }
}
