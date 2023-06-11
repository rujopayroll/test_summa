using System;

namespace domain.test.interfaces
{
    public interface IAgentFactory
    {
        IAgent CreateAgentA();
        IAgent CreateAgentB();
        IAgent CreateAgentC();
    }
}

