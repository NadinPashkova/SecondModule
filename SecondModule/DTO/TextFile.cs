using System;

namespace SecondModule.DTO
{
    public class TextFile : FileListBase
    {
        private string Content { get; }

        public TextFile(string stringToParse) : base(stringToParse)
        {
            Content = stringToParse.Substring(stringToParse.IndexOf(';')+1);
        }
        
        public override void Print()
        {
            Console.WriteLine($@"{FileName}
            {nameof(Extention)} : '{Extention}'
            {nameof(Size)} : '{Size}'
            {nameof(Content)} : '{Content}'");
        }
    }
}
