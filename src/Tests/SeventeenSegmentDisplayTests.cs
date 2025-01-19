using BlazorVintageKit.Components;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class SeventeenSegmentDisplayTests : BunitTestContext
    {
        [TestMethod]
        public void ValidateTestSanity()
        {
            // Arrange
            var cut = RenderComponent<SeventeenSegmentDisplay>(parameters => parameters
              .Add(p => p.Character, 'A')
            );
                        
            Action act = () => cut.Find("#p1.on");

            //Act & Assert that a missing element throws the expected exception
            act.Should().Throw<Bunit.ElementNotFoundException>();
        }

        [TestMethod]
        public void ARendersCorrectly()
        {
            // Arrange & Act
            var cut = RenderComponent<SeventeenSegmentDisplay>(parameters => parameters
              .Add(p => p.Character, 'A')
            );

            // Assert that the correct segments are lit
            cut.Find("#p1.off");
            cut.Find("#p2.off");
            cut.Find("#p4.off");
            cut.Find("#p3.off");
            cut.Find("#p5.on");
            cut.Find("#p6.on");
            cut.Find("#p7.off");
            cut.Find("#p8.off");
            cut.Find("#p9.on");
            cut.Find("#p10.on");
            cut.Find("#p11.on");
            cut.Find("#p12.on");
            cut.Find("#p13.on");
            cut.Find("#p14.on");
            cut.Find("#p15.off");
            cut.Find("#p16.off");
            cut.Find("#p17.off");

        }
    }
}
