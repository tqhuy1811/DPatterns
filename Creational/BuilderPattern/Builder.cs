
/*
 Another riddiculous pattern. just look at the amount of boilerplate. new constructor with lots of parameter is clear enough. 
 If somehow the parameter in constructor is optional then it's a sign to just create a new class that doesn't have those optional parameter
*/
namespace DesignPattern
{
    public class Car
    {
    }

    public class Manual
    {

    }
    public interface Builder {
        void Reset();
        void SetSeats();
    }

    public class SportCarBuilder : Builder
    {
        private Car _car;
        public void Reset()
        {
            _car = new Car();
        }

        public void SetSeats()
        {
           // set seats
        }

        public Car GetProduct()
        {
            return _car;
        }
    }

    public class SUVBuilder : Builder
    {
        private Manual manual;
        public void Reset()
        {
            manual = new Manual();
        }

        public void SetSeats()
        {
            // set seats
        }

        public Manual GetProduct()
        {
            return manual;
        }
    }

    public class Director
    {
        private readonly Builder _builder;

        public void ConstructSportCar()
        {
            _builder.Reset();
            _builder.SetSeats();
        }

          public void ConstructSuvCar()
        {
            _builder.Reset();
            _builder.SetSeats();
        }
    }
}