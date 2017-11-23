using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using ByteSizeLib;

namespace SecondModule
{
	public abstract class FileListBase
	{
		public FileType FileType { get; set; }

		public string FileName { get; set; }

		public string Size { get; set; }

		public string Extention { get; set; }

		public Double SizeInBytes => ByteSize.Parse(Size).Bytes;

		public FileListBase(string stringToParse)
		{
			FileName = new Regex(@"(^[a-zA-Z0-9]+([a-zA-Z\\_0-9\.-]*))").Match(stringToParse).Value;
			Extention = FileName.Substring(FileName.LastIndexOf('.') + 1);
			Size = new Regex(@"\((.+)\)").Match(stringToParse).Groups[1].Value;
		}

		public abstract void Print();

		
	}
}
