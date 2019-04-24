using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja.UnitTests
{
    public class HtmlFormatterTest
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
