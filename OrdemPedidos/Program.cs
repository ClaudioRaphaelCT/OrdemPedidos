using OrdemPedidos.Entities;
using OrdemPedidos.Entities.Enum;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do Cliente: ");
        Console.WriteLine("Nome: ");
        string nomeCliente = Console.ReadLine();
        Console.WriteLine("Email: ");
        string emailCliente = Console.ReadLine();
        Console.WriteLine("Aniversário: ");
        DateTime aniversario = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Entre com os dados da Ordem: ");
        Console.WriteLine("Status do pedido: ");
        OrdemStatus status = Enum.Parse<OrdemStatus>(Console.ReadLine());
        Console.WriteLine("Quantos items tem o pedido?");
        int quantidade = int.Parse(Console.ReadLine());

        Cliente cliente = new Cliente(nomeCliente,emailCliente,aniversario);
        Ordem ordem = new Ordem(DateTime.Now, status, cliente);

        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Insira dados do item Nº{i}");
            Console.WriteLine("Nome do produto: ");
            string produtoNome = Console.ReadLine();
            Console.WriteLine("Preco do produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade do produto");
            int produtoQuantidade = int.Parse(Console.ReadLine()); 
            Produto produto = new Produto(produtoNome, precoProduto);
            OrdemItem ordemItem = new OrdemItem(produtoQuantidade, precoProduto, produto);
            ordem.AddItem(ordemItem);
        }
        Console.WriteLine();
        Console.WriteLine("Ordem RESUMO");
        Console.WriteLine(ordem);

    }
}