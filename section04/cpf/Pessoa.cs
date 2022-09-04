using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpf
{
    internal class Pessoa
    {
        private string nome;
        private string cpf;

        public string VerificarCpf(string cpf)
        {
            return cpf.Substring(1,6);
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
