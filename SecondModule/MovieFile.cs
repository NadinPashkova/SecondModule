using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
	public class MovieFile : FileListBase
	{
		public string Length { get; set; }

		public string Resolution { get; set; }
		public override void ParseString()
		{
			throw new NotImplementedException();
		}
	}
}
