Basic OOP and Solution Design - Create Shapes

I would like to highlight few points of my design.

I have implemented the Textbox using a decorator. This Design allows us to extend easily the application in case we would
like to have a text in a circle: 
var textCircle = new TextDecorator(Circle.Create(new Location(5,5), 10), "sample text", "TextCircle");

I have added a second decorator with the name ColorDecorator to demonstrate how we can extend easily the widgets
and add other components like colour: 
var texboxColor = new ColorDecorator(new TextDecorator(Rectangle.Create(new Location(5, 5), 200, 100), "sample text"), "Red", "TextBoxColor");

To move the creation of the widgets out of the main method I have created dedicated factories. These factories are created 
dynamically using reflection to avoid if else statement and to make it easier to add more widgets.

I have tested one widget and one decorator. Tests need to be written for the other widgets too.

An improvement would be to use a custom exception instead of ArgumentException

