using System;
using SecondModule.Providers;

namespace SecondModule.DTO
{
    public class MovieFile : FileListBase
    {
        private string Length { get; }

        private string Resolution { get;  }

        public MovieFile(string stringToParse) : base(stringToParse)
        {
            Resolution = GetValue(ParsePatternProvider.ResolutionPattern, stringToParse);

            Length = GetValue(ParsePatternProvider.LengthPattern, stringToParse); 
        }

        public override void Print()
        {
            Console.WriteLine($@"{FileName}
            {nameof(Extention)} : '{Extention}'
            {nameof(Resolution)} : '{Size}'
            {nameof(Length)} : '{Length}'
            {nameof(Size)} : '{Size}'");
        }
    }
}
