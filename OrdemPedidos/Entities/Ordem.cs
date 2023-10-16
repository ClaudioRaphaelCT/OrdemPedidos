

using OrdemPedidos.Entities.Enum;
using System.Text;

namespace OrdemPedidos.Entities
{
    internal class Ordem
    {
        public DateTime Data { get; set; }
        OrdemStatus Status { get; set; }
        Cliente Cliente { get; set; }

        List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Ordem() { }

        public Ordem(DateTime data, OrdemStatus status, Cliente cliente)
        {
            Data = data;
            Status = status;
            Cliente = cliente;
            
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrdemItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public void AddItem(OrdemItem item) { Items.Add(item); }
        public void RemoveItem(OrdemItem item) { Items.Remove(item); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Data: " + Data.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Order items:");
            foreach (OrdemItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();
        }
    }   

   
}
