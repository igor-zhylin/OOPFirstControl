namespace FileMetaData
{
    using System.Linq;
    /// <summary>
    /// Class Movie Implements Image
    /// </summary>
    public class Movie : Image
    {
        public string Duration { get; set; }

        public Movie(
            string Name,
            string Format,
            string Size,
            string[] Atributes)
            : base(Name, Format, Size, Atributes)
        {
            Duration = Atributes.Last();
        }
    }
}
