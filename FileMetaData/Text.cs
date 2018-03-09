namespace FileMetaData
{
    using System.Linq;
   
    public class Text : MetaData
    {
        public string Content;

        public Text(
            string Name,
            string Format,
            string Size,
            string[] Atributes)
            : base(Name, Format, Size, Atributes)
        {
            this.Content = Atributes.First();
        }
    }
}
