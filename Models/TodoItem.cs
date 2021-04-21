namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string username { get; set; }  
        public string email { get; set; }
        public string IsComplete {get; set; }
    }

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string IsComplete {get; set; }
    }
}