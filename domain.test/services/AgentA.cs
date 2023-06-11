
namespace domain.test.services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using interfaces;

    public class AgentA : IAgent
    {
        public AgentA()
        {

        }

        public double getMedia(List<double> numbers)
        {
            double sum = 0;
            foreach (double val in numbers)
            {
                sum += val;
            }

            return sum / numbers.Count();
        }

        public string getStaircase(int n)
        {
            StringBuilder sb = new();
            for (int y = n - 1; y >= 0; y--)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x >= y)
                        sb.Append('#');
                    else
                        sb.Append(' ');
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}

