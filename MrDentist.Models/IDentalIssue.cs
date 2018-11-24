namespace MrDentist.Models
{
    public interface IDentalIssue
    {
        int Id { get; }
        IDentalIssueShape Shape { get; }
    }
}