namespace FileMetaData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnknownType : MetaData
    {

        public string[] UnknownAtributes { get; set; }

        public UnknownType(
            string Name,
            string Format,
            string Size,
            string[] Atributes)
            : base(Name, Format, Size, Atributes)
        {
            this.UnknownAtributes = Atributes;
        }
    }
}
