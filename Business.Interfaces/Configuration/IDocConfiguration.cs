namespace Business.Interfaces
{
    public interface IDocConfiguration
    {
        string Owner { get; set; }
        DocType Type { get; set; }
        string Font { get; set; }
        string Extension { get; set; }
        string Padding { get; set; }
        string Hash { get; set; }

    }
}
