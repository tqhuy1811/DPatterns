using System.Collections.Generic;

/*
 Haven't had the use case for this pattern. Maybe it's popular in desktop programming world. Not so much in web application
*/
namespace DesignPattern
{
    interface Graphic
    {
        //Prints the graphic.
        void Print();
    }

    /** "Composite" */
    class CompositeGraphic : Graphic
    {
        //Collection of child graphics.
        private readonly List<Graphic> graph = new List<Graphic>();

        //Adds the graphic to the composition.
        public void Add(Graphic graphic)
        {
            graph.Add(graphic);
        }

        public void Print()
        {
            foreach (var graphic in graph)
            {
                graphic.Print();
            }
        }
    }

    /** "Leaf" */
    class Ellipse : Graphic
    {
        //Prints the graphic.
        public void Print()
        {

        }
    }
}