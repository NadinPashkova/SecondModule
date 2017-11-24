using SecondModule.DTO;

namespace SecondModule
{
    internal static class Program
	{
	    private static void Main()
		{
		  //  Console.WriteLine("Plase type input data suing correct format in order to parse file data correctly");
		  //  var inputText = Console.ReadLine();
            
			const string inputText = @"Text: file.txt(6B); Some string content
				Image: img.bmp(19MB); 1920x1080
				 Text:data.txt(12B); Another string
				  Text:data1.txt(7B); Yet another string
					Movie:logan.2017.mkv(19GB); 1920x1080; 2h12m";
		

            var generalList = new GeneralList();

            //Parse input text and fill in File objects
		    generalList.SplitInputData(inputText);

            generalList.PrintFileList();
		}
	}
}
