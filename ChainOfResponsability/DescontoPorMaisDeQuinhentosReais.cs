namespace ChainOfResponsability
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.05;
            }

            //se o desconto não for aplicado, chamará o próximo desconto automaticamente
            return Proximo.Desconta(orcamento);
        }
    }
}
