
namespace domain.test.services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using interfaces;
    public class AgentB: IAgent
    {
        public AgentB()
        {
        }

        public  double getMedia(List<double> numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += 1 / num;
            }
          
            return numbers.Count() / sum;
        }

        public string getStaircase(int n)
        {
            StringBuilder sb = new();

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x >= y)
                    {

                        sb.Append('#');
                    }
                    else
                    {

                        sb.Append(' ');
                    }

                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}

