using System;
using domain.test.interfaces;
namespace domain.test.services
{
    public sealed class Print: IPrint
    {
        public Print()
        {

        }
        private static Print _instance = null;

        public static Print GetInstance()
        {
           
                if (_instance == null)
                {
                    _instance = new Print();
                }
                return _instance;
        }

        public void print(string value)
        {
            Console.WriteLine(value);
            Console.WriteLine("Presione <enter> para regresar al menú");
            Console.ReadLine();
        }
    }
}

