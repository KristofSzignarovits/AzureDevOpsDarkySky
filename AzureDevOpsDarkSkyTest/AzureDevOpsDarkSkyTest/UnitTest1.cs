using System;
using Xunit;
using AzureDevOpsDarkySky.Controllers;

namespace AzureDevOpsDarkSkyTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SampleDataController sdc = new SampleDataController();
            string expected = null;
            string realresult = sdc.ExecuteQuery(SampleDataController._url);
            Assert.NotEqual(expected, realresult); 
        }
    }
}
