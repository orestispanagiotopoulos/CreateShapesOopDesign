using DrawingPackage.Widget;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace DrawingPackage.Test.Widget
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
                () => Rectangle.Create(new Location(x,y), width, height));

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
                () => Rectangle.Create(new Location(x,y), width, height));

            Assert.That(ex.Message, Is.EqualTo("The parameters can not be negative"));
        }

        [Test]
        public void GetWidgetDescription_WhenValidRectangle_ThenReturnCorrectDescription()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var rec = Rectangle.Create(new Location(x, y), width, height);

            // Act
            var desc = rec.GetWidgetDescription();

            // Assert
            Assert.That(desc, Is.EqualTo("(0,0) width=1 height=2"));
        }

        [Test]
        public void RectangleCreate_WhenValidParameters_ThenCreateCorrectRectangle()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;

            // Act
            var rec = Rectangle.Create(new Location(x,y), width, height);

            // Assert
            Assert.That(rec.Location.X, Is.EqualTo(0));
            Assert.That(rec.Location.Y, Is.EqualTo(0));
            Assert.That(rec.Width, Is.EqualTo(width));
            Assert.That(rec.Height, Is.EqualTo(height));
            Assert.That(rec.Name, Is.EqualTo(typeof(Rectangle).Name));
        }

        [Test]
        public void Move_WhenValidRectangle_ThenMovePositionSuccesfully()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var newX = -1;
            var newY = -1;
            var rec = Rectangle.Create(new Location(x, y), width, height);

            // Act
            var movedRec = rec.Move(new Location(newX, newY));

            // Assert
            Assert.That(movedRec.Location.X, Is.EqualTo(newX));
            Assert.That(movedRec.Location.Y, Is.EqualTo(newY));
            Assert.That(movedRec.Name, Is.EqualTo(typeof(Rectangle).Name));
        }
    }
}
