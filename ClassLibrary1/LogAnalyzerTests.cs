using NUnit.Framework;

namespace LogAn.UnitTests
{
	[TestFixture]
	public class LogAnalyzerTests
	{
		[Test]
		public void IsValidLogFileName_BadExtension_ReturnsFaslse()
		{
			var analyzer = new LogAnalyzer();
			var result = analyzer.IsValidLogFileName("filewithbadextension.foo");
			Assert.False(result);
		}

		[Test]
		public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
		{
			var analyzer = new LogAnalyzer();
			var result = analyzer.IsValidLogFileName("filewithgoodextension.slf");
			Assert.True(result);
		}

		[Test]
		public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
		{
			var analyzer = new LogAnalyzer();
			var result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");
			Assert.True(result);
		}
	}
}