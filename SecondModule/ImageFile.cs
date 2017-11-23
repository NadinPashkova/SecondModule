using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecondModule
{
	public class ImageFile : FileListBase
	{
		public string Resolution { get; set; }

		public ImageFile(string stringToParse) : base(stringToParse)
		{
			Resolution = new Regex(@"(\d+х\d+)").Match(stringToParse).Value;
		}

		public override void Print()
		{
			throw new NotImplementedException();
		}
	}
}
