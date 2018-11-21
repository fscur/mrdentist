namespace MrDentist.Models
{
    public class Cavity : IDentalEvent
    {
        private Point shape;

        public int Id { get; private set; }
        public IDentalEventShape Shape { get { return shape; }}

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
