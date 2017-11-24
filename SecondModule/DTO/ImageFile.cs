using System;
using SecondModule.Providers;

namespace SecondModule.DTO
{
    public class ImageFile : FileListBase
    {
        private string Resolution { get; }

        public ImageFile(string stringToParse) : base(stringToParse)
        {
            Resolution = GetValue(ParsePatternProvider.ResolutionPattern, stringToParse);
        }

        public override void Print()
        {
            Console.WriteLine($@"{FileName}
            {nameof(Extention)} : '{Extention}'
            {nameof(Size)} : '{Size}'
            {nameof(Resolution)} : '{Resolution}'");
        }
    }
}
