using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle("зелёный", new int[] { 15, 174, 541 }),
            new Rectangle("розовый", new int[] { 15, 0, 1 }),
            new Circle("белый", new int[] { 15, 3, 4 }),
            new Rectangle("синий", new int[] { 15, 12, 20 }) };
            foreach (var item in shapes)
            {
                item.draw();
            }
            Console.WriteLine(new Circle("зелёный", new int[] { 15, 174, 541 }).equals(new Circle("зелёный", new int[] { 15, 174, 541 })));
        }
        public abstract class Shape
        {
            public abstract void draw();
            public string color;
            public abstract bool equals(Shape obj);
        }

        public class Rectangle : Shape
        {
            private int[] coords;
            public override void draw()
            {
                Console.WriteLine("           ");
                Console.WriteLine(" ********* ");
                Console.WriteLine(" ********* ");
                Console.WriteLine(" ********* ");
                Console.WriteLine(" ********* ");
                Console.WriteLine(" ********* ");
            }
            public override bool equals(Shape obj)
            {
                return (obj.color == this.color && obj.GetType() == typeof(Rectangle));
            }
            public Rectangle(string color, int[] coords)
            {
                this.coords = coords;
                this.color = color;
            }
        }
        internal class Circle : Shape
        {
            private int[] coords;
            public override void draw()
            {
                Console.WriteLine("  *******  ");
                Console.WriteLine(" ********* ");
                Console.WriteLine(" ********* ");
                Console.WriteLine("  *******  ");
            }
            public override bool equals(Shape obj)
            {
                return (obj.color == this.color && obj.GetType() == typeof(Circle));
            }
            public Circle(string color, int[] coords)
            {
                this.coords = coords;
                this.color = color;
            }
        }


    }
}

