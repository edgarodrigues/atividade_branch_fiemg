using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int qtdDezena, // Adicionado a virgula
    qtdJogoInformada, // Adicionado a variável
    qtdDezenaInformada;

decimal valorPremio;

bool repetir = false; //Corrigindo de string para bool e adicionado retorno false 

Console.Write("Deseja realizar quantos jogos: ");
if (int.Parse(Console.ReadLine(), out qtdJogoInformada,))
{
    do
    {
        Console.Write("Informar a quantidade de dezena: ");
        if (int.Parse(Console.ReadLine(), out qtdDezenaInformada,))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                    repetir = true;
                else
                        repetir = false;

            if (repetir == false)
            {
                Console.WriteLine();
                for (qtdJogoInformada = 1; qtdJogoInformada <= qtdJogoInformada; qtdJogoInformada++)
                {
                    for (qtdDezena = 1; qtdDezena <= qtdDezenaInformada)
                    {

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Quantidade dezena menor que 6");
                repetir = true;

            }
        else
            {
                repetir = true;
                Console.WriteLine("Número inválido!");
            }
        }
        //while (repetir == true);
    }
else

        Console.WriteLine("Número inválido!");
}

// Solicitar o valor do prêmio

Console.Write("Informe o valor do prêmio: ");
if (inteiro.TryParse(Console.ReadLine(), out valorPremio))
            {

inteiro valordopremio = inteiro.Parse(Console.ReadLine());

                Console.WriteLine($"0.75m do premio sera para quem acertar as 6 dezenas: {valordopremio * 0.75m}");
				Console.WriteLine($"0.15m do premio sera para quem acertar as 5 dezenas: {valordopremio * 0.15m}");
				Console.WriteLine($"0.10m do premio sera para quem acertar as 4 dezenas: {valordopremio * 0.10m}");
				
				Console.WriteLine("Foi informado texto no lugar de numero: ");
            }
			
			else 
			
			}
                
				Console.Write("Numero invalido!Por favor,tente informar o numero novamente!: ");
			
			}
		
	



           
