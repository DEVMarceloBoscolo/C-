int pontuacaoTotal = 0;
       
        Console.WriteLine("Qual sua tolerância a risco?");
        Console.WriteLine("1- Baixa, 2- Média, 3- Alta");
        pontuacaoTotal += int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nQual seu objetivo de investimento?");
        Console.WriteLine("1- Preservação, 2- Crescimento, 3- Especulação");
        pontuacaoTotal += int.Parse(Console.ReadLine());

        
        Console.WriteLine("\nQual seu horizonte de tempo?");
        Console.WriteLine("1- Curto Prazo, 2- Médio Prazo, 3- Longo Prazo");
        pontuacaoTotal += int.Parse(Console.ReadLine());

       
        Console.WriteLine("\n--- Resultado ---");
        if (pontuacaoTotal >= 3 && pontuacaoTotal <= 4)
        {
            Console.WriteLine("Seu perfil é: Conservador");
        }
        else if (pontuacaoTotal >= 5 && pontuacaoTotal <= 7)
        {
            Console.WriteLine("Seu perfil é: Moderado");
        }
        else 
        {
            Console.WriteLine("Seu perfil é: Arrojado");
        }

        Console.WriteLine("Pontuação total: " + pontuacaoTotal);
        Console.WriteLine("\nPressione qualquer tecla para finalizar.");
        Console.ReadKey();

