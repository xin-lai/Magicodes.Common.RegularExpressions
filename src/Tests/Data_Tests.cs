using System;
using System.Text.RegularExpressions;
using Magicodes.Common.RegularExpressions;
using Magicodes.Common.RegularExpressions.Data;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class Data_Tests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Data_Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData("2019-08-01", true)]
        //[InlineData("2019/08/01", true)]
        public void Test_Date(string value, bool result)
        {
            _testOutputHelper.WriteLine(value);
            
            Matchs.IsMath(Dates.Date, value).ShouldBe(result);
        }
    }
}
