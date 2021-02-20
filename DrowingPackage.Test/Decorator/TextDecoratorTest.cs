using DrawingPackage.Decorator;
using DrawingPackage.Enumeration;
using DrawingPackage.Widget;
using NUnit.Framework;

namespace DrawingPackage.Test.Decorator
{
    public class TextDecoratorTest
    {
        [Test]
        public void GetWidgetDescription_WhenValidTextDecorator_ThenReturnCorrectDescription()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var text = "test text";
            var textDec = new TextDecorator(Rectangle.Create(
                new Location(x, y), width, height), text, WidgetType.Textbox.ToString());

            // Act
            var desc = textDec.GetWidgetDescription();

            // Assert
            Assert.That(desc, Is.EqualTo("(0,0) width=1 height=2 Text=\"test text\""));
        }

        [Test]
        public void TextDecorator_WhenOptionalParameterIsNotPresent_ThenUseTheNameOfUnderlineShape()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var newX = -1;
            var newY = -1;
            var text = "test text";

            var textBox = new TextDecorator(Rectangle.Create(
                new Location(x, y), width, height), text);

            // Act
            var movedTextbox = textBox.Move(new Location(newX, newY));

            // Assert
            Assert.That(textBox.Name, Is.EqualTo(typeof(Rectangle).Name));
        }

        [Test]
        public void TextDecorator_WhenOptionalParameterIsPresent_ThenOverrideTheNameWithTheOptionlaParameter()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var text = "test text";

            var name = WidgetType.Textbox.ToString();

            // Act
            var textBox = new TextDecorator(
                Rectangle.Create(new Location(x, y), width, height), text, name);

            // Assert
            Assert.That(textBox.Name, Is.EqualTo(name));
        }

        [Test]
        public void TextDecorator_WhenValidParameters_ThenCreateCorrectTextDecorator()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var text = "test text";

            // Act
            var textDec = new TextDecorator(Rectangle.Create(new Location(x, y), width, height), text);

            // Assert
            Assert.That(textDec.Location.X, Is.EqualTo(x));
            Assert.That(textDec.Location.Y, Is.EqualTo(y));
            Assert.That(textDec.Text, Is.EqualTo(text));
        }

        [Test]
        public void Move_WhenValidTextDecorator_ThenMovePositionSuccesfully()
        {
            // Arrange
            var width = 1;
            var height = 2;
            var x = 0;
            var y = 0;
            var newX = -1;
            var newY = -1;
            var text = "test text";

            var textBox = new TextDecorator(Rectangle.Create(
                new Location(x, y), width, height), text);

            // Act
            var movedTextbox = textBox.Move(new Location(newX, newY));

            // Assert
            Assert.That(movedTextbox.Location.X, Is.EqualTo(newX));
            Assert.That(movedTextbox.Location.Y, Is.EqualTo(newY));
        }
    }
}
