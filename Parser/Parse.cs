
namespace Parser
{
    using System.Collections.Generic;
    using FileMetaData;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Parse
    {
        #region Separators

        private const string ExtentionSeparator = ".";
        private const string FileTypeSeparator = ":";
        private const string Separator = ";";

        #endregion

        private string[] _fileEntities;
        private string _input;
        private List<MetaData> metaData;

        #region Costructors

        public Parse()
        {
            metaData = new List<MetaData>();
        }

        public Parse(string input)
        {
            this._input = input;
            metaData = new List<MetaData>();
        }

        #endregion

        public void SetInputString(string input)
        {
            this._input = input;
        }

        public List<MetaData> RunParser()
        {



            return metaData;
        }

        private MetaData CreateNewFileMetaData(
            string Name,
            string Format,
            string Size,
            string[] Atributes)
        {
            switch (Format.ToLower())
            {
                case "text": return new Text(Name, Format, Size, Atributes);
                case "movie": return new Movie(Name, Format, Size, Atributes);
                case "image": return new Image(Name, Format, Size, Atributes);
                default:
                    return new UnknownType(Name, Format, Size, Atributes);
            }
        }
    }
}
