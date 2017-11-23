using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SecondModule
{
    public class GeneralList
    {
        private readonly string _input;

        public List<TextFile> TextFileList { get; set; }

        public List<ImageFile> ImageFileList { get; set; }

        public List<MovieFile> MovieFileList { get; set; }

        public GeneralList(string input)
        {
            _input = input;
			SplitInputData();
		}

        private void SplitInputData()
        {
			TextFileList = new List<TextFile>();
			ImageFileList = new List<ImageFile>();
			MovieFileList = new List<MovieFile>();

			var split = _input.Split('\n').Select(x => x.Trim());

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
				Console.WriteLine(FileType.Text);

				TextFileList.OrderBy(d => d.SizeInBytes);

				foreach (var file in TextFileList)
				{
					file.Print();
				}

			}

			Console.ReadKey();

		}

		
    }
}
