namespace FileMetaData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Text : MetaData
    {
        protected string Content;

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
