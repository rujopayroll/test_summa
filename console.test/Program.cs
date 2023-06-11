
using System.Text;
using console.test;

namespace console.test
{
	using domain.test.services;
	using domain.test.interfaces;

	class Program
	{
		int num; int type;
		static void Main(string[] args)
		{
			MainMenu();
		}

		static void MainMenu()
        {
			Console.Clear();
			Console.WriteLine("Bienvenido aplicación Agentes\r");
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine("1. Trabajar como agente");
			Console.WriteLine("2. Salir");
			Console.WriteLine("Seleccione la opción");
			string option = Console.ReadLine();
			int numericOption;
			bool isNumber = int.TryParse(option, out numericOption);
			if (isNumber)
			{
				switch (option)
				{
					case "1":
						agent();
						break;
					case "2":
						exit();
						break;
					default:
						invalidOption();
						break;
				}
				
			}
			else
            {
				invalidOption();
			}
			MainMenu();
		}

		static void agent()
		{
			Console.Clear();
			Console.WriteLine("Seleccione el tipo de agente");
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine("1. Agente A");
			Console.WriteLine("2. Agente B");
			Console.WriteLine("3. Agente C");

			string option = Console.ReadLine();
			int numericOption;
			bool isNumber = int.TryParse(option, out numericOption);

			//int agentType = Convert.ToInt32(Console.ReadLine());
			if (isNumber)
			{

				IAgentFactory factory = new AgentFactory();
				//IAgent Agent= null;
				switch (numericOption)
				{
					case 1:
						
						operation(factory.CreateAgentA());
						break;
					case 2:
						
						operation(factory.CreateAgentB());
						break;
					case 3:
						
						operation(factory.CreateAgentC());
						break;
					default:
						invalidOption();
						
						break;
				}
			}
			else
            {
				invalidOption();
			}
			agent();
		}

		static void operation(IAgent Agent)
        {
			Console.Clear();
		
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine($"\nEsta trabajanto como agente");
			Console.WriteLine("Seleccione que operacion quiere realizar");
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine("1. Optener Media");
			Console.WriteLine("2. Dibujar scalera");
			Console.WriteLine("3. Seleccionar un nuevo agente");

			int oper = Convert.ToInt32(Console.ReadLine());
			Print s1 = Print.GetInstance();
			switch (oper)
            {
				case 1:
					Console.WriteLine("Ingrese la lista de numeros");
					List<double> list = new() { };
					double valor;
					string n;
					bool esNumero;
					do
					{
						n = Console.ReadLine();
						esNumero = double.TryParse(n, out valor);
						if (esNumero)
							list.Add(float.Parse(n));
					}
					while (esNumero);
					double number = Agent.getMedia(list);
					s1.print("El valor de la media es " + number.ToString());
					operation(Agent);
					break;
				case 2:
					Console.WriteLine("Número para generar escalera");
					int value = Convert.ToInt32(Console.ReadLine());
					if (value < 0 || value > 100)
						Console.WriteLine("el numero debe estar entre 1 y 100");
					else
					{
						string shapestr = Agent.getStaircase(value);
						s1.print(shapestr);
					}
					operation(Agent);
					break;
				case 3:
					agent();
					break;
                default:
					Console.WriteLine("Ingrese una opcion Valida");
					Console.Clear();
					operation(Agent);
					break;
            }
		}

		static void exit()
		{
			Console.WriteLine("¿Está seguro de salir del programa?");
			Console.WriteLine("Pesione Enter para confirmar");
			Console.ReadLine();
			System.Environment.Exit(1);
		}

		static void invalidOption()
        {
			Console.WriteLine("Ingrese una opcion Valida");
			Console.ReadLine();
		}
	}
}






