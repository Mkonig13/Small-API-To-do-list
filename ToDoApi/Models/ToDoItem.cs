namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public long id {  get; set; }
        public string? name { get; set; }
        public bool? IsComplete { get; set; }
    }
}
