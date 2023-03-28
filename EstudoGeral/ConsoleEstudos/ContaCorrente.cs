using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleEstudos.PessoaFisicas;

namespace ConsoleEstudos.ContaCorrente
{
    internal class ContaCorrente
    {
        public PessoaFisica titular;

        private int numero_da_conta;
        private int digito_da_conta;
        private int agencia_da_conta;

        private int db_contas_criadas = 1098;
        private int db_digito_da_conta;
        private int db_agencia_da_conta;

        // Fazer um teste de que cria a conta um numero a mais que tem reservada no histórico
        // Digito da conta selecionado por Estado que a pessoa vive
        // Agencia definida pela Cidade


        public ContaCorrente(string estado_de_origem, string cidade_de_origem)
        {
            switch(estado_de_origem)
            {
                case "SP": digito_da_conta = 1;  break;
                case "AC": digito_da_conta = 2;  break;//acre
                case "AL": digito_da_conta = 3;  break;//Alagoas
                case "AP": digito_da_conta = 4;  break;//Amapá
                case "AM": digito_da_conta = 5;  break;//Amazonas
                case "BA": digito_da_conta = 6;  break;//Bahia
                case "CE": digito_da_conta = 7;  break;//Ceara
                case "DF": digito_da_conta = 8;  break;//Distrito Federal
                case "ES": digito_da_conta = 9;  break;//Espirito Santo
                case "GO": digito_da_conta = 0;  break;//Goiás
                case "MA": digito_da_conta = 10; break;//Maranhão
                case "MT": digito_da_conta = 11; break;//Mato Grosso
                case "MS": digito_da_conta = 12; break;// Mato Grosso do Sul
                case "MG": digito_da_conta = 13; break;// Minas Gerais
                case "PA": digito_da_conta = 14; break;//Pará
                case "PB": digito_da_conta = 15; break;//Paraiba
                case "PR": digito_da_conta = 16; break;//PAraná
                case "PE": digito_da_conta = 17; break;//Pernambuco
                case "PI": digito_da_conta = 18; break;//Piaui
                case "RJ": digito_da_conta = 19; break;//Rio de Janeiro
                case "RN": digito_da_conta = 20; break;//Rio GRande do Norte
                case "RS": digito_da_conta = 21; break;//Rio Grande do Sul
                case "RO": digito_da_conta = 22; break;//Rondonia
                case "RR": digito_da_conta = 23; break;//Roraima
                case "SC": digito_da_conta = 24; break;//Santa Catarina
                case "SE": digito_da_conta = 25; break;//Sergipe
                case "TO": digito_da_conta = 26; break;//Tocantins
                default: throw new ArgumentException("Erro, Não encontrado o Estado");
            }
            agencia_da_conta = 1;
            numero_da_conta = db_contas_criadas + 1;

            //resumoDaContaCriada();

        }

        public string resumoDaContaCriada()
        {
            string s = ($"Conta Criada com sucesso, aqui estão os dados;\n" +
                $"Esse é o seu número da conta {numero_da_conta} \n" +
                $" De Digito {digito_da_conta} - que foi definido pelo estado de origem\n" +
                $"E a sua Agencia é {agencia_da_conta}");
            return s;
        }

        public string titularDaConta()
        {
            return titular.apresentacaoPessoaFisica();
        }
    }
}
