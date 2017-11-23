using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
	public class TextFile : FileListBase
	{
		public string Content { get; set; }

		public TextFile(string stringToParse) : base(stringToParse)
		{
			Content = stringToParse.Substring(stringToParse.IndexOf(';')+1);
		}
		
		public override void Print()
		{
			Console.WriteLine($@"{FileName}
			Extention : '{Extention}'
			Size : '{Size}'
			Content : '{Content}'");
		}
	}
}
