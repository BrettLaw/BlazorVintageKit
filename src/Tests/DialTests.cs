using BlazorVintageKit;
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
    public class DialTests : BunitTestContext
    {
        [TestMethod]
        public void DialRadiusZero()
        {
            var options = new DialOptions()
            {
                DialRadius = 0
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );
        }

        [TestMethod]
        public void DialRangeZero()
        {
            var options = new DialOptions()
            {
                DialRange = 0
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );
        }

        [TestMethod]
        public void FaceAngleZero()
        {
            var options = new DialOptions()
            {
                FaceArcAngle = -1
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );
        }

        [TestMethod]
        public void IndicatorCountZero()
        {
            var options = new DialOptions()
            {
                IndicatorCount = 0
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );
        }

        [TestMethod]
        public void SubIndicatorCountZero()
        {
            var options = new DialOptions()
            {
                SubIndicatorCount = 0
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );
        }

        [TestMethod]
        public void ValueDivisorZero()
        {
            var options = new DialOptions()
            {
                ValueDivisor = 0
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );
        }

        [TestMethod]
        public void RiskModeOffRendersNoRiskElements()
        {
            var options = new DialOptions()
            {
                RiskMode = false
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );

            //risk mode is not rendered
            Action act = () => cut.Find("#g_risk");
            act.Should().Throw<ElementNotFoundException>();
        }

        [TestMethod]
        public void InnerCircleModeOnRendersInnerCircleElements()
        {
            var options = new DialOptions()
            {
                InnerCircleMode = true
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );

            //inner circle mode is rendered
            cut.Find("#c_innerCircle");
        }

        [TestMethod]
        public void SmithsModeOnRendersSmithsElements()
        {
            var options = new DialOptions()
            {
                SmithsMode = true
            };

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );

            //smith mode is rendered
            cut.Find("#g_smithsRing");
        }


        [TestMethod]
        public void DefaultRendersCorrectly()
        {
            var options = new DialOptions();

            // Arrange & Act
            var cut = RenderComponent<Dial>(parameters => parameters
              .Add(p => p.Options, options)
            );

            // Assert that the elements are present
            var outerCircle = cut.Find("#c_outer");
            outerCircle.MarkupMatches(@$"<circle id=""c_outer"" cx=""50"" cy=""50"" r=""{options.DialRadius}"" fill=""{options.DialColour}"" />");

            //risk mode is default
            cut.Find("#g_risk");

            //inner circle mode is false by default
            Action act = () => cut.Find("#c_innerCircle");
            act.Should().Throw<ElementNotFoundException>();

            //inner ring mode is false by default
            act = () => cut.Find("#g_innerRing");
            act.Should().Throw<ElementNotFoundException>();

            //smiths ring mode is false by default
            act = () => cut.Find("#g_smithsRing");
            act.Should().Throw<ElementNotFoundException>();

            //indicators are default
            cut.Find("#g_indicators");

            //text indicators are default
            cut.Find("#g_textIndicators");

            //text labels are default
            cut.Find("#t_makers");
            cut.Find("#t_key");

            //rest mode is false by default
            act = () => cut.Find("#g_resetButton");
            act.Should().Throw<ElementNotFoundException>();

            act = () => cut.Find("#p_reset");
            act.Should().Throw<ElementNotFoundException>();

            act = () => cut.Find("#g_reset");
            act.Should().Throw<ElementNotFoundException>();

            //pointer is default
            cut.Find("#g_pointer");
            cut.Find("#p_pointer");

            //boss is default
            cut.Find("#c_boss");
            cut.Find("#c_bossCenter");

            //rim is default
            cut.Find("#c_rim");
        }
    }
}
