namespace Models
{
    public class ToDoItem(string task) : Entity
    {
        public string Task { get => task; set => task = value; }
        public bool IsCompleted { get; set; }
    }
}
