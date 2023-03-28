using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstudos.PessoaFisicas
{
    internal class PessoaFisica
    {

        
        private string nomePessoaFisica { get; set; }
        private string sobrenomePessoaFisica { get; set; }
        private string cpfPessoaFisica { get; set; }

        public PessoaFisica(string cpf, string nome , string sobrenome) 
        {
            this.cpfPessoaFisica = cpf;
            this.nomePessoaFisica = nome;
            this.sobrenomePessoaFisica  = sobrenome;
        }


        public string apresentacaoPessoaFisica()
        {
            string s = $"Nome: {nomePessoaFisica} {sobrenomePessoaFisica} de CPF {cpfPessoaFisica}";
            return s;
        }


    }
}
