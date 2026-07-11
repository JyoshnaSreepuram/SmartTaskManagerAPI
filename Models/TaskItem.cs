namespace SmartTaskManagerAPI.Models
{
    public class TaskItem
    {
        public int TaskId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
