using System.Text.RegularExpressions;
using ByteSizeLib;
using SecondModule.Providers;

namespace SecondModule.DTO
{
    public abstract class FileListBase
    {
        public FileType FileType { get; set; }

        protected string FileName { get; }

        protected string Size { get; }

        protected string Extention { get; }

        public double SizeInBytes => ByteSize.Parse(Size).Bytes;

        protected FileListBase(string stringToParse)
        {
            FileName = GetValue(ParsePatternProvider.FileNamePattern, stringToParse);
            Extention = FileName.Substring(FileName.LastIndexOf('.') + 1);
            Size = GetValue(ParsePatternProvider.SizePattern, stringToParse);

        }

        public abstract void Print();

        protected static string GetValue(string pattern, string inputString)
        {
            var regex = new Regex(pattern);

            if (regex.IsMatch(inputString))
                return regex.Match(inputString).Groups[1].Value;

            return pattern.Equals(ParsePatternProvider.SizePattern) ? "0" : "Value was not found";
        }
    }
}
