using System.Linq;

namespace ChainOfResponsability
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public DescontoPorVendaCasada(Desconto proximo)
        {
            Proximo = proximo;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("Lapis", orcamento) && Existe("Borracha", orcamento))
            {
                return orcamento.Valor * 0.08;
            }
            return Proximo.Desconta(orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
