using RevImposto;

Console.WriteLine("Dados do funcionário");
Funcionario funcionario = new Funcionario("Thiago Bailarina", 10.0, 9200.00);

funcionario.SalarioComDesconto();
double salarioLiquido = funcionario.SalarioComDesconto();
Console.WriteLine($"Salário líquido: {salarioLiquido}");
