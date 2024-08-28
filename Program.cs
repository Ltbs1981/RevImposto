using RevImposto;

Console.WriteLine("Dados do funcionário");
Funcionario funcionario = new Funcionario("Thiago Bailarina", 10.0, 9200.00);

funcionario.SalarioComDesconto();
double liquido = funcionario.SalarioComDesconto();
Console.WriteLine($"Salário líquido: {liquido}");

double valorAumento = 15;

liquido = funcionario.SalarioBruto + valorAumento * 100;

Console.WriteLine($"Novo Salário líquido: {liquido}");