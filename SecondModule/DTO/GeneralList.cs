using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondModule.DTO
{
    public class GeneralList
    {
        private List<TextFile> TextFileList { get; set; }

        private List<ImageFile> ImageFileList { get; set; }

        private List<MovieFile> MovieFileList { get; set; }

        public GeneralList()
        {
            TextFileList = new List<TextFile>();
            ImageFileList = new List<ImageFile>();
            MovieFileList = new List<MovieFile>();
        }

        public void SplitInputData(string input)
        {
            var split = input.Split('\n').Select(x => x.Trim());

            foreach (var fileInfo in split)
            {
                var category = fileInfo.Substring(0, fileInfo.IndexOf(':'));

                var stringToParse = fileInfo.Replace(category + ":", "").Trim();

                if (!Enum.IsDefined(typeof(FileType), category))
                    throw new Exception("File type is not defiend");

                var categoryEnum = (FileType)Enum.Parse(typeof(FileType), category);

                FillInList(categoryEnum, stringToParse);
            }
        }

        private void FillInList(FileType fileType, string stringToParse)
        {
            switch (fileType)
            {
                case FileType.Text:
                    TextFileList.Add(new TextFile(stringToParse));
                    break;
                case FileType.Image:
                    ImageFileList.Add(new ImageFile(stringToParse));
                    break;
                default:
                    MovieFileList.Add(new MovieFile(stringToParse));
                    break;
            }
        }

        public void PrintFileList()
        {
            if (TextFileList.Any())
            {
                Console.WriteLine(FileType.Text + "files:");

                var sortedList = TextFileList.OrderBy(d => d.SizeInBytes);

                foreach (var file in sortedList)
                {
                    file.Print();
                }
            }

            if (ImageFileList.Any())
            {
                Console.WriteLine(FileType.Image + "files:");

                var sortedList = ImageFileList.OrderBy(d => d.SizeInBytes);

                foreach (var file in sortedList)
                {
                    file.Print();
                }
            }

            if (MovieFileList.Any())
            {
                Console.WriteLine(FileType.Movie + "files:");

                var sortedList = MovieFileList.OrderBy(d => d.SizeInBytes);

                foreach (var file in sortedList)
                {
                    file.Print();
                }
            }

            Console.ReadKey();
        }
    }
}
