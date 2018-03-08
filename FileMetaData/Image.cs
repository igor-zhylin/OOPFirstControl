namespace FileMetaData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Image : MetaData
    {
        protected string Resolution { get; set; }

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
