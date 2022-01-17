using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de descontos!");

            CalculadorDeDesconto calculador = new CalculadorDeDesconto();

            Orcamento orcamento = new Orcamento(20);
            orcamento.AdicionaItem(new Item("Caneta"));
            orcamento.AdicionaItem(new Item("Lápis"));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine($"Desconto do orçamento 1: {desconto}");


            Orcamento orcamento2 = new Orcamento(100);
            orcamento2.AdicionaItem(new Item("Caneta"));
            orcamento2.AdicionaItem(new Item("Lapis"));
            orcamento2.AdicionaItem(new Item("Papel"));
            orcamento2.AdicionaItem(new Item("Caderno"));
            orcamento2.AdicionaItem(new Item("Borracha"));

            double desconto2 = calculador.Calcula(orcamento2);
            Console.WriteLine($"Desconto do orçamento 2: {desconto2}");


            Orcamento orcamento3 = new Orcamento(800);
            orcamento3.AdicionaItem(new Item("Fogao"));

            double desconto3 = calculador.Calcula(orcamento3);
            Console.WriteLine($"Desconto do orçamento 3: {desconto3}");

            Console.ReadKey();
        }
    }
}
