using DrawingPackage.Widget;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;


namespace DrowingPackage.Test.Widget
{
    public class RectangleTest
    {
        [Test]
        public void RectangleCreate_WhenWidthIsSmallerThanZero_ThenThrowArgumentException()
        {
            // Arrange
            var width = -1;
            var height = 2;
            var x = 0;
            var y = 0;

            // Act - Assert
            var ex = Assert.Throws<ArgumentException>(
                () => Rectangle.Create(x, y, width, height));

            Assert.That(ex.Message, Is.EqualTo("The parameters can not be negative"));
        }

        [Test]
        public void RectangleCreate_WhenHeightIsSmallerThanZero_throwArgumentException()
        {
            // Arrange
            var width = 1;
            var height = -2;
            var x = 0;
            var y = 0;

            // Act - Assert
            var ex = Assert.Throws<ArgumentException>(
                () => Rectangle.Create(x, y, width, height));

            Assert.That(ex.Message, Is.EqualTo("The parameters can not be negative"));
        }

        [Test]
        public void RectangleCreate_WhenValidRectngle_ThenCreateCorrectRectangle()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;

            // Act
            var rec = Rectangle.Create(x, y, width, height);

            // Assert
            Assert.That(rec.X, Is.EqualTo(0));
            Assert.That(rec.Y, Is.EqualTo(0));
            Assert.That(rec.Width, Is.EqualTo(width));
            Assert.That(rec.Height, Is.EqualTo(height));
            Assert.That(rec.Name, Is.EqualTo(typeof(Rectangle).Name));
        }

        [Test]
        public void GetWidgetDescription_WhenValidRectngle_ThenReturnCorrectDescription()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var rec = Rectangle.Create(x, y, width, height);

            // Act
            var desc = rec.GetWidgetDescription();

            // Assert
            Assert.That(desc, Is.EqualTo("(0,0) width=1 height=2"));
        }
    }
}
