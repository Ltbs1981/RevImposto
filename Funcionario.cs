using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevImposto
{
    public class Funcionario
    {
        public string Nome;
        public Double Imposto;
        public double SalarioBruto;


        public Funcionario(string nome, double imposto, double salarioBruto)
        {
            Nome = nome;
            Imposto = imposto;
            SalarioBruto = salarioBruto;
        }
            
        public double SalarioComDesconto()
        {
                        return SalarioBruto - Imposto * 100;
        }
        }
}
