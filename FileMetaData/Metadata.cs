namespace FileMetaData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MetaData
    {
        protected string Format { get; set; }
        protected string Name { get; set; }
        protected string Size { get; set; }
        protected string[] AdditionalAtributes;

        public MetaData(
            string Name,
            string Format,
            string Size,
            string [] Atributes)
        {
            this.Name = Name;
            this.Format = Format;
            this.Size = Size;
            this.AdditionalAtributes = Atributes;
        }
    }
}
