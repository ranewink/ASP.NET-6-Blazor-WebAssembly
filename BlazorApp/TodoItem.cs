public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}