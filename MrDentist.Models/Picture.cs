using System.Drawing;

namespace MrDentist.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Image Image { get; set; }
    }
}