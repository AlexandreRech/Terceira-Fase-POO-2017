namespace ListaComprasWindowsApp
{
    public class Produto
    {
        public Produto(string d, double pe, string um)
        {
            descricao = d;
            precoEstimado = pe;
            unidadeMedida = um;
        }

        public string descricao;

        public double precoEstimado;

        public string unidadeMedida;

        public override string ToString()
        {
            return descricao;
        }
    }
}
