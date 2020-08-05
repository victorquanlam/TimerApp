public class TodoItem
{
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    // important for security aspect which makes a difference from TodoItemDTO
    public string Secret { get; set; }
}