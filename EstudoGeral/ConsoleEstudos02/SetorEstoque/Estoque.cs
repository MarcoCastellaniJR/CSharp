using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstudos02.SetorEstoque
{
    internal class Estoque
    {
        // Comecei a fazer com uma List mas eu queria um tamanho fixo para o estoque não sair do controle
        //List<int> gaveta = new List<int>();
        int[] gaveta = new int[32];
        string nomeDoSetor;

        public Estoque(string nomeDoSetor)
        {
            this.nomeDoSetor = nomeDoSetor;
        }

        public void guardarPedaco()
        {
            //for(int i = 0; i < 32; i++)
            //{
            //    if (gaveta[i] ==0) { gaveta[i] = 1; }
            //}
            int i = 0;
            while ( i < 32) { 
                if (gaveta[i] == 1 ) { i++; }
                else {
                    gaveta[i] = 1;
                    if (gaveta[31] == 1) { break;//depois adicionar um erro falando que a gaveta esta lotada
                    }
                    break;
                }
                
            }
        }

        public void retirarPedaco()
        {
            int i = 0;
            while( i < 32) { if (gaveta[i] == 0 ) { i++; }
            else { gaveta[i] = 0; break; }
            }
        }
        public string listarQuantidadeLivre()
        {
            int espacoVazio = 0;
            int espacoUsado = 0;
            //for(int i = 0; i < gaveta.Count; i++) {
            //    if (gaveta[i] == 1) { espacoUsado++; }
            //    else { espacoVazio++; }
            //}
            foreach (var gav in  gaveta) {
                if (gav == 1) { espacoUsado++; }
                else { espacoVazio++; }
            }
            string s = $" O setor {nomeDoSetor} Tem {espacoVazio} espaços Livres e {espacoUsado} Espaços usados";
            return s;
        }



    }
}
