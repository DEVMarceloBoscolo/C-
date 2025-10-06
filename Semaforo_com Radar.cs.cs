Random random = new Random();
int multa = 0;
for (int ciclo = 1; ciclo <= 5; ciclo++)
{
    Console.WriteLine($"----Ciclo {ciclo} ----");


    int carro = random.Next(2);
    

    // verde
    Console.WriteLine("sinal verde por 5 s.");
    Thread.Sleep(5000);

    // amarelo
    Console.WriteLine("sinal amarelo por 2 s.");
    if (carro == 1)
    {
        multa++;
    }
    else
  
    Thread.Sleep(2000);

    // vermelho
    Console.WriteLine("sinal vermelho por 5 s.");
    if (carro == 1)
    {
        multa++;
    }
    else
    Thread.Sleep(5000);

    Console.WriteLine("\n--------------------------\n");
}
            
Console.WriteLine($"numero de multas:------\n{multa}");
    
    
