using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_2_Funcionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - SalarioBruto*(Imposto / 100);
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto *= ((porcentagem / 100)+SalarioBruto);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, " +
                $"Salário Líquido: R${SalarioLiquido()}, " +
                $"Imposto: R${SalarioBruto - SalarioLiquido()}";
        }
    }
}
