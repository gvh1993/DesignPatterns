namespace DesignPatterns.Patterns.Bridge.Abstractions
{
    public interface IResource
    {
        string Snippet { get; set; }
        byte[] image { get; set; }
        string Title { get; set; }
        string Url { get; set; }
    }
}