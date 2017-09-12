using Business.Interfaces;

namespace Business.Implementations
{
    public class DocConfiguration : IDocConfiguration
    {
        public string Owner { get; set; }
        public DocType Type { get; set; }
        public string Font { get; set; }
        public string Extension { get; set; }
        public string Padding { get; set; }
        public string Hash { get; set; }
    }
}
