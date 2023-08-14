
using DesignPatterns.Behavioral.Command.FX;

namespace DesignPatterns.Behavioral.Command
{
    public class Demo
    {
        public static void Run()
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);

            var button = new Button(command);
            button.Click(); 

            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackWhiteCommand());

            button = new Button(composite);
            button.Click();
        }
    }
}
