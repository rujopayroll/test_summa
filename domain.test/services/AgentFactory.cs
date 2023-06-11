
namespace domain.test.services
{
    using System;
    using interfaces;

    public class AgentFactory : IAgentFactory
    {
        public AgentFactory()
        {
        }

        public IAgent CreateAgentA()
        {
            return new AgentA();
        }

        public IAgent CreateAgentB()
        {
            return new AgentB();
        }

        public IAgent CreateAgentC()
        {
            return new AgentC();
        }
    }
}

