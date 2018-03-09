namespace FileMetaData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MetaData
    {
        public string Format { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string[] AdditionalAtributes;

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

        public override string ToString()
        {
            return  $" Name {Name}; \n" +
                    $" Format {Format}; \n" +
                    $" Size {Size}; \n" +
                    $" Atributes {string.Join("\n" , AdditionalAtributes)};";
        }
    }
}