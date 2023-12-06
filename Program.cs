using System;

class Robo
{
    public int VelocidadeAtual { get; private set; }
    public int VelocidadeMinima { get; private set; }
    public int VelocidadeMaxima { get; private set; }

    public Robo(int velocidadeMinima, int velocidadeMaxima)
    {
        VelocidadeAtual = velocidadeMinima;
        VelocidadeMinima = velocidadeMinima;
        VelocidadeMaxima = velocidadeMaxima;
    }
//logica
    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        
        string[] valoresMinMax = Console.ReadLine().Split();
        int Vmin = int.Parse(valoresMinMax[0]);
        int Vmax = int.Parse(valoresMinMax[1]);

        
        Robo robo = new Robo(Vmin, Vmax);

        
        string comandos = Console.ReadLine();

       
        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.Acelerar();
            }
            else if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }

        
        Console.WriteLine(robo.VelocidadeAtual);
    }
}