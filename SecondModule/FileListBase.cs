using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
	public abstract class FileListBase
	{
		public FileType FileType { get; set; }

		public string FileName { get; set; }

		public string Size { get; set; }

		public string Extention { get; set; }

		public string StringToParse { get; set; }

		public abstract void ParseString();

	}
}
