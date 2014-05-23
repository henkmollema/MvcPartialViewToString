public class BaseController : Controller
{
    /// <summary>
    /// Renders the specified partial view to a string.
    /// </summary>
    /// <param name="viewName">The name of the partial view.</param>
    /// <param name="model">The model.</param>
    /// <returns>The partial view as a string.</returns>
    protected string RenderPartialViewToString(string viewName, object model)
    {
        if (string.IsNullOrEmpty(viewName))
        {
            viewName = ControllerContext.RouteData.GetRequiredString("action");
        }
 
        ViewData.Model = model;
 
        using (var sw = new StringWriter())
        {
            // Find the partial view by its name and the current controller context.
            ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);

            if (viewResult.View == null)
            {
              throw new ArgumentException(string.Format("Could not find the view with the specified name '{0}'.", viewName), "viewName");
            }
 
            // Create a view context.
            var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
 
            // Render the view using the StringWriter object.
            viewResult.View.Render(viewContext, sw);
 
            return sw.GetStringBuilder().ToString();
        }
    }
}
