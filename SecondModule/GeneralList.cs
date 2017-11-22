using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
	public class GeneralList
	{
		public List<TextFile> TextFileList { get; set; }

		public List<ImageFile> ImageFileList { get; set; }

		public List<MovieFile> MovieFileList { get; set; }

		public GeneralList()
		{
			TextFileList = new List<TextFile>();
			ImageFileList = new List<ImageFile>();
			MovieFileList = new List<MovieFile>();
		}

		public void GetFileTypeList()
		{
			var test = new object[] { TextFileList, ImageFileList, MovieFileList };

			
		}
	}
}
