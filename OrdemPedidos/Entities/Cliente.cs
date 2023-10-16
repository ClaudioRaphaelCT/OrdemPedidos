

namespace OrdemPedidos.Entities
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario {get; set; }

        public Cliente() { }

        public Cliente(string nome, string email, DateTime aniversario)
        {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
        }

        public override string ToString()
        {
            return $" {Nome} , ({Aniversario}) - E-mail: {Email}";
        }
    }
}
