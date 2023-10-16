
namespace OrdemPedidos.Entities
{
    internal class OrdemItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        Produto Produto { get; set; }

        public OrdemItem() { }

        public OrdemItem(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal() { return Preco * Quantidade; }

        public override string ToString()
        {
            return $"{Produto.Nome}, R$ {Preco}, Quantidade: {Quantidade}, Subtotal: {SubTotal()}";
        }

    }
}
