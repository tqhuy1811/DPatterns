using System;

/*
 Pretty useless pattern. Introduces lots of complexity. Need control statement to create approriate concrete factories
*/
namespace DesignPattern
{
    public interface Button 
    {
        void Paint();
    }

    public class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("Windown button paint");
        }
    }

      public class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("Mac button paint");
        }
    }

    public interface GUIFactory
    {
        Button CreateButton();
    }

    public class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }
    }

    public class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }
    }
}