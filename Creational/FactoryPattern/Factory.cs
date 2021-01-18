using System;

/*
  Has some mixture with template pattern. Still useless nevertheless
*/
namespace DesignPattern
{
    public interface Chair
    {

    }

    public abstract class ChairFactory 
    {
        public abstract Chair CreateChair();

        public void Sit()
        {
            var chair = CreateChair();
        }
    }

    public class SuperChair : ChairFactory
    {
        public override Chair CreateChair()
        {
            return null;
        }
    }
}