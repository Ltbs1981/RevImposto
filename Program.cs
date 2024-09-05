using System;
using RevImposto; // Fazendo referência ao namespace onde a classe Funcionario está

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dados do funcionário");

        
        Funcionario funcionario = new Funcionario("Thiago Bailarina", 10.0, 9200.00);


        double liquido = funcionario.SalarioComDesconto();
        Console.WriteLine($"Funcionário {funcionario.Nome}\nSalário líquido: {liquido:f2}");

        
        funcionario.AumentandoSalario(22);
        Console.WriteLine($"Novo Salário bruto: {funcionario.SalarioBruto:f2}");
    }
}
