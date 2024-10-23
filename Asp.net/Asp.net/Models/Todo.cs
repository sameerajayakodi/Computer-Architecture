namespace Asp.net.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public string Status { get; set; }
    }
}
