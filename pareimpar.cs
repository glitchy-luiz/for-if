Console.WriteLine("Digite um valor positivo: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0)
            {
                Console.WriteLine("valor negativo");
            }
            else if (valor == 0)
            {
                Console.WriteLine("Zero é neutro");
            }
            else if ((valor%2)==0)
            {
                Console.WriteLine("Numero é par!");
            }
            else
            {
                Console.WriteLine("Numero é impar!");
            }


            Console.WriteLine("Escolha um número entre 3 e 9");
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i);
                Console.Write("+");
                total += i;
            }
            Console.Write("=" + total);
