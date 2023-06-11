
namespace domain.test.services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using interfaces;
    public class AgentC: IAgent
    {
        public AgentC()
        {

        }

        public double getMedia(List<double> numbers)
        {
            numbers.Sort();
            int n = numbers.Count();
            if (n % 2 == 0)
                return (numbers[n / 2 - 1] + numbers[n / 2]) / 2;
            else
                return numbers[n / 2];
         }

        public string getStaircase(int n)
        {
            StringBuilder sb = new();
            int total = ((n - 1) * 2) + n;
            int size = (total - n) / 2;

            for (int y = n - 1; y >= 0; y--)
            {   
                for (int x = 0; x < total; x++)
                {
                    if (x < size)
                        sb.Append(" ");
                    else
                    {
                        if (x < total - size)
                            sb.Append("#");
                        else
                            sb.Append(" ");
                    }
                }
                sb.Append("\n");
                size--;
            }

            char[] stringArray = sb.ToString().ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            sb.Append(reversedStr.Substring(total + 2));

            return sb.ToString();
        }

    }
}

