namespace DesignPatterns.Creational.Factory.Matcha
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> model);
    }
}