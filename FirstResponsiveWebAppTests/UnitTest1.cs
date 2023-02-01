using FirstResponsiveWebAppAdolfson;
using FirstResponsiveWebAppAdolfson.Models;

namespace FirstResponsiveWebAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void trueTest()
        {
            ResponsiveWebAppModel test = new ResponsiveWebAppModel();
            test.Name = "Antony Adolfson";
            test.BirthYear = 2002; 

            string expected = "Antony Adolfson's age: 21";
            string actual;

            actual = test.AgeThisYear(test.Name, test.BirthYear);

            Assert.Equal(expected, actual);
        }

    }
}