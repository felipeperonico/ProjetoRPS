using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRPS
{
    class Jogador
    {
        String Nome;
        Char Escolha;

        public Jogador(String Nome, Char Escolha)
        {
            this.Nome = Nome;
            this.Escolha = Escolha;
        }

        public String getJogador()
        {
            return "[\""+this.Nome + "\",\"" + this.Escolha + "\"]";
        }

        public String getNome()
        {
            return this.Nome;
        }

        public void setNome(String Nome)
        {
            this.Nome= Nome;
        }

        public Char getEscolha()
        {
            return this.Escolha;
        }

        public void setEscolha(Char Escolha)
        {
            this.Escolha = Escolha;
        }
    }
}
