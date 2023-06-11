
namespace console.test
{
    using System;
    using domain.test.services;
    using domain.test.interfaces;

    public class Client
    {
        readonly int num;
        int type;
        public Client()
        {
           
        }

        public void Main(int type)
        {
            ClientMethod(new AgentFactory(), type);
        }

        public void ClientMethod(IAgentFactory factory, int type)
        {

            List<float> list = new List<float>() { 15, 17, 13, 12 };
            IAgent Agent;
            switch (type)
            {
                case 1:
                    Agent = factory.CreateAgentA();
                    break;
                case 2:
                   Agent = factory.CreateAgentB();
                    break;
                case 3:
                   Agent = factory.CreateAgentC();
                    break;
                default:
                    break;
            }



            Console.Write("Presione una tecla para salir de la palicacion");
            Console.ReadKey();


        }

    }
}

