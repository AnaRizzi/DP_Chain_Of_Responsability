namespace ChainOfResponsability
{
    public class CalculadorDeDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            //cria um objeto para cada desconto possível:
            Desconto d1 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new DescontoPorCincoItens();

            //da pra passar por construtor também, mas tem que passar a mesma instância usada aqui
            Desconto d2 = new DescontoPorVendaCasada(d3);

            //Cria um desconto que retorna 0 para ser o último da fila
            //Se nenhum for usado, este será chamado e retornará um valor, nunca chamará um próximo
            Desconto d4 = new SemDesconto();

            //Aqui a gente determina a ordem dos descontos, formando uma "fila":
            d1.Proximo = d2;
            //d2.Proximo = d3;
            d3.Proximo = d4;

            //chama só o primeiro, que ele mesmo irá chamar os outros caso não consiga dar o desconto
            return d1.Desconta(orcamento);
        }
    }
}
