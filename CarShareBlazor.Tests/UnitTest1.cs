using Bunit;
using Bunit.TestDoubles;
using CarShareBlazor.Components.Pages;

namespace CarShareBlazor.Tests
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void CounterShouldImcrementWhenClicked()
        {
            // Arrange
            this.AddTestAuthorization();
            var cut = RenderComponent<Counter>();

            //Act
            cut.Find("button").Click();

            //Assert
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}