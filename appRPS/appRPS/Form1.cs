using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRPS
{
    public partial class frmPrincipal : Form
    {
        private List<Jogador> ListJog = new List<Jogador>();
        /*
         * ESTOU DEIXANDO DIVERSOS ARQUIVOS COMENTADOS,
         * MAS EM PROJETOS EM GRUPO, OU QUE OUTROS IRAM TRABALHAR,
         * DEIXO APENAS O NECESSARIO DE INFORMAÇÃO
         */

        public frmPrincipal()
        {
            InitializeComponent();
            PreencheCbbEscolha();
            //     Preenchelist();
        }
        /////////////////////////////////////////////////////////////////////

        // apenas para ajudar nos testes
        private void Preenchelist()
        {
            ListJog.Add(new Jogador("Lucas", Convert.ToChar(("P"))));
            ListJog.Add(new Jogador("Armando", Convert.ToChar(("S"))));
            ListJog.Add(new Jogador("Leticia", Convert.ToChar(("R"))));
            ListJog.Add(new Jogador("Camila", Convert.ToChar(("S"))));
            ListJog.Add(new Jogador("Leandro", Convert.ToChar(("S"))));
            ListJog.Add(new Jogador("Dave", Convert.ToChar(("P"))));
            ListJog.Add(new Jogador("Leonardo", Convert.ToChar(("R"))));
            ListJog.Add(new Jogador("Rafaela", Convert.ToChar(("P"))));

            ListJog.Add(new Jogador("Felipe", Convert.ToChar(("S"))));
            ListJog.Add(new Jogador("Kelly", Convert.ToChar(("S"))));
            ListJog.Add(new Jogador("Nadia", Convert.ToChar(("R"))));
            ListJog.Add(new Jogador("Larissa", Convert.ToChar(("P"))));
            ListJog.Add(new Jogador("Sabrina", Convert.ToChar(("R"))));
            ListJog.Add(new Jogador("Soraya", Convert.ToChar(("P"))));
            ListJog.Add(new Jogador("Moacir", Convert.ToChar(("S"))));
            ListJog.Add(new Jogador("Emanuela", Convert.ToChar(("R"))));
            PreencheBox();
        }

        private void PreencheBox()
        {
            ltbListJogador.Items.Clear();
            foreach (Jogador L in ListJog)
            {
                ltbListJogador.Items.Add(L.getJogador());
            }
        }
        /////////////////////////////////////////////////////////////////////
        private void PreencheCbbEscolha()
        {
            cbbEscolha.Items.Add("Rock");
            cbbEscolha.Items.Add("Paper");
            cbbEscolha.Items.Add("Scissors");
        }

        private void LimparCampos()
        {
            ttbNome.Text= "";
            cbbEscolha.SelectedIndex = -1;
        }

        private void WrongNumberOfPlayersError()
        {
            MessageBox.Show("Número de jogadores para Duelo devem ser 2", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void NoSuchStrategyError()
        {
            MessageBox.Show("Uma das escolhas dos jogadores esta fora do padrão do jogo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private Jogador Disputa(Jogador J1, Jogador J2)
        {
            /* R= Rock / Pedra
             * S= Scissors / Tesoura
             * P= Paper / Papel
             */

            // R > S ,S > P, P > R

            //Empate Cuidamos aqui
            if (J1.getEscolha() == J2.getEscolha())
                return J1;

            if(J1.getEscolha() == 'R')
            {
                if(J2.getEscolha() == 'P')
                    return J2;
                else
                    if(J2.getEscolha() == 'S')
                            return J1;
            }
            else
                if(J1.getEscolha() == 'P')
                {
                    if(J2.getEscolha() == 'R')
                        return J1;
                    else
                        if(J2.getEscolha() == 'S')
                            return J2;
                }
                else
                    if(J1.getEscolha() == 'S')
                    {
                        if(J2.getEscolha() == 'P')
                            return J1;
                        else
                            if(J2.getEscolha() == 'R')
                                return J2;
                    }
            //Em caso de alguma falha , ele retornara nullo, para devido cuidado 
            return null;
        }

        private void rps_game_winner(List<Jogador> LJ)
        {
            bool v= true;
            Jogador Vencedor; 

            if (LJ.Count == 2)
            {
                Console.WriteLine("Lista de Jogadores:");
                
                //Loop que Verifica se as jogadas escolhidas estão corretas
                for (int i = 0; i < LJ.Count && v == true; i++)
                {
                    Console.WriteLine(LJ[i].getJogador());
                    if (LJ[i].getEscolha() != 'R' &&
                        LJ[i].getEscolha() != 'P' &&
                        LJ[i].getEscolha() != 'S')
                        v = false;
                }

                if (v == true)
                {
                    ltbPrompt.Items.Add("["+LJ[0].getJogador()+","+LJ[1].getJogador()+"]");
                    Vencedor = Disputa(LJ[0], LJ[1]);
                    if (Vencedor != null)
                    {
                        MessageBox.Show("O Vencedor do Duelo : " + Vencedor.getJogador(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ltbPrompt.Items.Add("VENCEDOR: " + Vencedor.getJogador());
                    }
                    else
                        MessageBox.Show("Erro ao Processar a Disputa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
                else
                    NoSuchStrategyError();
            }
            else
                WrongNumberOfPlayersError();
        }

        private void rps_tournament_winner(List<Jogador> LJ)
        {
            List<Jogador> LJV;
           // bool P = true; // inicio do jogo!
            Jogador Vencedor;

            

            do
            {
                Console.WriteLine("[");
                ltbPrompt.Items.Add("[");

                LJV = new List<Jogador>();
                for(int i=0,j=0; i < LJ.Count;i++, i++, j++)
                {
                    
                //Processo para fazer os desesnhos no debug

                // comentado pois inicialmente eu iria desenhar a penas a primeira fase de torneio, mas fiz o processo para desenhar tudo
                //if (P == true)
                //  {
                    if (j % 2 == 0)
                    {
                        Console.WriteLine(" [");
                        ltbPrompt.Items.Add(" [");
                    }
                    Console.Write("  [" + LJ[i].getJogador() + "," + LJ[i + 1].getJogador() + "]");
                    ltbPrompt.Items.Add("  [" + LJ[i].getJogador() + "," + LJ[i + 1].getJogador() + "]");
                    if (i + 2 < LJ.Count)
                    {
                        Console.Write(",");
                        //ltbPrompt.Items.Add(",");
                    }
                    Console.WriteLine("");
                    if (j % 2 != 0)
                    {
                        Console.Write(" ]");
                        ltbPrompt.Items.Add(" ]");
                        if (i + 2 < LJ.Count)
                        {
                            Console.Write(",");
                            // ltbPrompt.Items.Add(",");
                        }
                        Console.WriteLine("");
                    }
               //     }

                    Vencedor = Disputa(LJ[i], LJ[i + 1]);
                    LJV.Add(Vencedor);
                }
                LJ = LJV;
               // P = false;   

                if (LJ.Count == 1)
                {
                    Console.WriteLine(" ]");
                    ltbPrompt.Items.Add(" ]");
                }
                Console.WriteLine("]");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                ltbPrompt.Items.Add("]");
                ltbPrompt.Items.Add("----------------------------------------------------------------------------------------------");

            }while(LJ.Count > 1);

            MessageBox.Show("O Vencedor do Duelo foi: " + LJ[0].getJogador(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ltbPrompt.Items.Add("VENCEDOR: " +LJ[0].getJogador());

        }

        // é um embaralhamento simples, apenas pra ter uma diferença nos resultados caso queira
        private void embaralharJogadores()
        {
            int N;
            Random rNum = new Random();
            Jogador J;

            for (int i = 0; i < ListJog.Count; i++)
            {
                N= rNum.Next(ListJog.Count);
                J = ListJog[N];
                ListJog[N] = ListJog[i];
                ListJog[i] = J;
            }
            PreencheBox();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ttbNome.Text.Length > 0)
            {
                if (cbbEscolha.SelectedIndex >= 0 )
                {
                    Console.WriteLine(ttbNome.Text + " " + Convert.ToChar((cbbEscolha.Text.Substring(0, 1))) + " - " + cbbEscolha.Text);
                   
                    ListJog.Add(new Jogador(ttbNome.Text, Convert.ToChar((cbbEscolha.Text.Substring(0,1)))));

                    ltbListJogador.Items.Add(ListJog[ListJog.Count-1].getJogador());

                    LimparCampos();
                }
                else
                    MessageBox.Show("Selecione Rock, Paper ou Scissors para jogar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            else
                MessageBox.Show("Coloque o nome do Jogador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            ltbPrompt.Items.Clear();
            if (rbtDuelo.Checked == true)
            {
                if (ListJog.Count > 0)
                {
                    Console.WriteLine("Iniciando Duelo");
                    rps_game_winner(ListJog);
                }
                else
                    MessageBox.Show("Para jogar um Duelo é necessario o número de 2 Jogadores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                if (rbtTorneio.Checked == true )
                {
                    if (ListJog.Count > 0)
                    {
                        Console.WriteLine("Iniciando Torneio");
                        if (MessageBox.Show("Deseja embaralhar os jogadores?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {

                            embaralharJogadores();

                        }
                        rps_tournament_winner(ListJog);
                    }
                    else
                        MessageBox.Show("Para jogar torneio é necessario o número de 2^n Jogadores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Selecione o tipo de jogada, Duelo ou Torneio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ltbListJogador.Items.Clear();
            ListJog.Clear();
            ltbPrompt.Items.Clear();
        }
    }
}
