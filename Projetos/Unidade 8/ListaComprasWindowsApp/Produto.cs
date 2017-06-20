namespace ListaComprasWindowsApp
{
    public class Produto
    {
        public Produto(string d, decimal pe, string um)
        {
            descricao = d;
            precoEstimado = pe;
            unidadeMedida = um;
        }

        public string descricao;

        public decimal precoEstimado;

        public string unidadeMedida;

        public override string ToString()
        {
            return $" {unidadeMedida} - {descricao}";
        }
    }
}
