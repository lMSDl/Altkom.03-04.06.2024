namespace Models
{
    public class ToDoItem(string task)
    {
        public int Id { get; set; }
        public string Task { get => task; set => task = value; }
        public bool IsCompleted { get; set; }
    }
}
