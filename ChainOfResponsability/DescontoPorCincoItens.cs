namespace ChainOfResponsability
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 5)
            {
                return orcamento.Valor * 0.1;
            }

            //se o desconto não for aplicado, chamará o próximo desconto automaticamente
            return Proximo.Desconta(orcamento);
        }
    }
}
