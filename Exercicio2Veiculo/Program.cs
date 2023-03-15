using Exercicio2Veiculo;

internal class Program
{
    private static void Main(string[] args)
    {
        Onibus onibus = new Onibus();
        Bicicleta bicicleta = new Bicicleta();
        Moto moto = new Moto();
        Carro carro = new Carro();

        onibus.Nome = "213";
        onibus.Marca = "Mercedez Benz";
        onibus.QPassageiros = 33;
        onibus.Cor = "Verde";
        onibus.tOleo = 112000;
        onibus.cmpViacao = "Paraty";
        onibus.passagens = 62;

        bicicleta.Nome = "Caloi 10";
        bicicleta.Marca = "Caloi";
        bicicleta.Cor = "Prata";
        bicicleta.catraca = "Shimano";
        bicicleta.pedal = "Gts";

        moto.Nome = "Fazer";
        moto.Marca = "Yamaha";
        moto.QPassageiros = 2;
        moto.Cor = "Preta";
        moto.tOleo = 85960;
        moto.cilindrada = 250;
        moto.relacao = "KOZH456";

        carro.Nome = "Gol 1.6";
        carro.Marca = "VolksWagen";
        carro.QPassageiros = 4;
        carro.Cor = "Prata";
        carro.tOleo = 1500;
        carro.modelo = "Geração 2";
        carro.estqNovo = 86;

        Console.WriteLine(onibus.ToString());
        Console.WriteLine();
        Console.WriteLine(bicicleta.ToString());
        Console.WriteLine();
        Console.WriteLine(moto.ToString());
        Console.WriteLine();
        Console.WriteLine(carro.ToString());

    }
}