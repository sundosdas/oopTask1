using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopTask1
{
    public interface IEngine
    {
        void Start();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started");
        }
    }

    public class Car
    {
        private IEngine eng;
        public Car(IEngine engine)
        {
            this.eng = engine;
        }
        public void Start() 
        {
            eng.Start();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            Car car = new Car(engine);
            car.Start();    
        }
    }
}
