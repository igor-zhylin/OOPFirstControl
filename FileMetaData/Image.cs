namespace FileMetaData
{
    using System.Linq;

    public class Image : MetaData
    {
        public string Resolution { get; set; }

        public Image(
            string Name,
            string Format,
            string Size,
            string[] Atributes
            ) : base(Name, Format, Size, Atributes)
        {
            Resolution = Atributes.First();
        }
    }
}
