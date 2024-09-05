namespace RevImposto
{
    public class Funcionario
    {
        
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private double _imposto;
        public double Imposto
        {
            get { return _imposto; }
            set { _imposto = value; }
        }

        private double _salarioBruto;
        public double SalarioBruto
        {
            get { return _salarioBruto; }
            set { _salarioBruto = value; }
        }


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
