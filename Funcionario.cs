namespace RevImposto
{
    public class Funcionario
    {

        public string  Nome { get; set; }
        public double  Imposto { get; set; }
        public double  SalarioBruto { get; set; }

        public Funcionario(string nome, double imposto, double salarioBruto)
        {
            Nome = nome;
            Imposto = imposto;
            SalarioBruto = salarioBruto;
        }

        // Método para calcular salário com desconto
        public double SalarioComDesconto()
        {
            return SalarioBruto - (Imposto / 100 * SalarioBruto); // Ajuste na fórmula para percentual correto
        }

        // aumentando salariocom bônus
        public void AumentandoSalario(double bonus)
        {
            SalarioBruto += (bonus / 100 * SalarioBruto); // Ajuste para percentual correto
        }
    }
}
