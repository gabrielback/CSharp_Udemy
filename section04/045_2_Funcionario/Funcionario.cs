using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_2_Funcionario
{
    internal class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double imposto;

        public string Nome { get => nome; set => nome = value; }
        public double SalarioBruto { get => salarioBruto; set => salarioBruto = value; }
        public double Imposto { get => imposto; set => imposto = value; }
        

        public double SalarioLiquido()
        {
            return salarioBruto - (Imposto/100*salarioBruto);
        }

        public void AumentarSalario(double aumentoPercentual)
        {
            SalarioBruto *=  (aumentoPercentual/100)+1;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, " +
                $"Salário Bruto: {salarioBruto}, " +
                $"Salário Líquido: R${SalarioLiquido()}, " +
                $"Imposto: R${SalarioBruto - SalarioLiquido()}";
        }
    }
}
