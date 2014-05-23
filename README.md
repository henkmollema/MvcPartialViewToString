MvcPartialViewToString
======================

Small code example to render a partial view to a string with ASP.NET MVC.

There are two files available:
- [BaseController.cs](https://github.com/HenkMollema/MvcPartialViewToString/blob/master/BaseController.cs): this file contains an instance method (`protected`) and can be added to your own base controller class if you have one.

- [ControllerExtensions.cs](https://github.com/HenkMollema/MvcPartialViewToString/blob/master/ControllerExtensions.cs): this file contains an extension method for the `Controller` class.

Both files do exactly the same thing, just a different way to call the `RenderPartialViewToString` method.
