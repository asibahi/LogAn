using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
	public class LogAnalyzer
	{
		public bool IsValidLogFileName(string fileName) => fileName.EndsWith(".SLF") ? true : false;
	}
}
