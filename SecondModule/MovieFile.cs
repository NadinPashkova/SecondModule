using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecondModule
{
	public class MovieFile : FileListBase
	{
		public string Length { get; set; }

		public string Resolution { get; set; }

		public MovieFile(string stringToParse) : base(stringToParse)
		{
			Resolution = new Regex(@"(\d+х\d+)").Match(stringToParse).Value;

			Length = new Regex(@"(\d+h\d+)").Match(stringToParse).Value;
		}
		
		public override void Print()
		{
			throw new NotImplementedException();
		}
	}
}
