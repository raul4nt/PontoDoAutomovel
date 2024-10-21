namespace PontoDoAutomovel.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }

        public decimal CalcularComissao()
        {
            throw new NotImplementedException("A função CalcularComissao não foi implementada ainda.");
        }
    }
}
