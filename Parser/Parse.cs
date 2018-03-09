
namespace Parser
{
    using System.Collections.Generic;
    using FileMetaData;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System;

    public class Parse
    {
        #region Separators

        private const char ExtentionSeparator = '.';
        private const char FileTypeSeparator = ':';
        private const char EntitySeparator = ';';

        #endregion

        #region Private Fields

        private string[] _fileEntities;

        #endregion

        #region Costructors

        public Parse()
        {
            
        }

        #endregion

        public List<MetaData> RunParser(string input)
        {
            var fileEntries = input
               .Split(
                   new string[] { Environment.NewLine },
                   StringSplitOptions.RemoveEmptyEntries)
               .Select(_ => _.Trim())
               .Select(ParseFilesEntities)
               .ToList();

            return fileEntries;
        }

        private void EntitiesSplitter(string input)
        {
            _fileEntities = input.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

        }

        private MetaData ParseFilesEntities(string input)
        {
            var FilesDescription = input.Split(EntitySeparator);
            var FormatAndName = input.Split(EntitySeparator).First();
            var Format = FormatAndName.Split(FileTypeSeparator).First();
            var NameAndSize = FormatAndName.Split(FileTypeSeparator).Last();
            var Name = NameAndSize.Split('(').First();
            var Size = NameAndSize
                .Replace(Name, string.Empty)
                .Trim('(', ')');
            var Attributes = input.Split(EntitySeparator).Skip(1).ToArray();

            return CreateNewMetaDataObj(Name, Format, Size, Attributes);
        }

        private MetaData CreateNewMetaDataObj(
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
