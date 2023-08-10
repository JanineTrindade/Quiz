using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabQuiz
{
    public partial class Form1 : Form
    {
        int quest1 = 1;
        int quest2 = 1;
        int quest3 = 1;
        int acertos = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox.SelectedItem == "MARVEL")
            {
                BackColor = Color.DarkGray;
                groupBox1.Visible = true;
                groupBox1.Enabled = true;
                groupBox2.Visible = true;
                groupBox2.Enabled = true;

                labelquest.Text = "Questão 1 - Quem foi o primeiro vingador?";
                rdoAltA.Text = "A. Capitão America";
                rdoAltB.Text = "B. Thor";
                rdoAltC.Text = "C. Hulk";
                rdoAltD.Text = "D. Viuva Negra";
                rdoAltNada.Text = "Nenhuma das Anteriores";
            }

            else if (comboBox.SelectedItem == "STAR WARS")
            {
                BackColor = Color.DarkSalmon;
                groupBox1.Visible = true;
                groupBox1.Enabled = true;
                groupBox2.Visible = true;
                groupBox2.Enabled = true;

                labelquest.Text = "Questão 1 - Quem é a Irmã de" + " \n" + "Luke Skywalker?";
                rdoAltA.Text = "A. Léia";
                rdoAltB.Text = "B. Padmé";
                rdoAltC.Text = "C. Rey";
                rdoAltD.Text = "D. Ahsoka";
                rdoAltNada.Text = "Nenhuma das Anteriores ";
            }

            else if (comboBox.SelectedItem == "DC COMICS")
            {
                BackColor = Color.Tan;
                groupBox1.Visible = true;
                groupBox1.Enabled = true;
                groupBox2.Visible = true;
                groupBox2.Enabled = true;

                labelquest.Text = "Questão 1 - Qual o verdadeiro nome do Superman?";
                rdoAltA.Text = "A. Hal Jordan";
                rdoAltB.Text = "B. Clark Kent";
                rdoAltC.Text = "C. Jor-El";
                rdoAltD.Text = "D. Kal-El";
                rdoAltNada.Text = "Nenhuma das Anteriores";
            }
            else
            {
                groupBox1.Visible = false;
                groupBox1.Enabled = false;
                groupBox2.Visible = false;
                groupBox2.Enabled = false;
            }


        }

        ////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox.SelectedItem == "MARVEL")
            {
                switch (quest1)
                {
                    case 1:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {

                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. Capitão America");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 2 - Quem é o personagem mais velho?";
                        rdoAltA.Text = "A. Magneto";
                        rdoAltB.Text = "B. Prof. Xavier";
                        rdoAltC.Text = "C. Wolverine"; 
                        rdoAltD.Text = "D. Capitão America";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    case 2:
                        if (rdoAltC.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: C. Wolverine");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 3 - Qual o nome da armadura " + " \n" + " do Homem de Ferro?";
                        rdoAltA.Text = "A. Sexta-feira";
                        rdoAltB.Text = "B. Jarvis";
                        rdoAltC.Text = "C. Mark";
                        rdoAltD.Text = "D. Serginho";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 3:
                        if (rdoAltC.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: C. Mark");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 4 - Em 'Vingadores: Guerra Infinita'," + " \n" + "Dr. Estranho viu quantos futuros?";
                        rdoAltA.Text = "A. 1,4 Milhões";
                        rdoAltB.Text = "B. 4 Milhões";
                        rdoAltC.Text = "C. 14 Milhões";
                        rdoAltD.Text = "D. 41 Milhões";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 4:
                        if (rdoAltC.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: C. 14 Milhões");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 5 - Wolverine é de que País?";
                        rdoAltA.Text = "A. Estados Unidos";
                        rdoAltB.Text = "B. Canadá";
                        rdoAltC.Text = "C. Austrália";
                        rdoAltD.Text = "D. Inglaterra";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 5:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. Canadá");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 6 -  Bruce Banner é exposto a qual raio" + " \n" + " que o transforma no Hulk?";
                        rdoAltA.Text = "A. Raio Ultravioleta";
                        rdoAltB.Text = "B. Raio - X";
                        rdoAltC.Text = "C. Raio Ômega";
                        rdoAltD.Text = "D. Raio Gama";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 6:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Raio Gama");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = " Questão 7 - Como Thor e o seu povo" + " \n" + "chamam o Planeta Terra?";
                        rdoAltA.Text = "A. Midgard";
                        rdoAltB.Text = "B. Asgard";
                        rdoAltC.Text = "C. Valhalla";
                        rdoAltD.Text = "D. Titan";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 7:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. Midgard");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 8 - Quem é o Líder" + " \n" + "do Quarteto Fantástico?";
                        rdoAltA.Text = "A. Surfista Prateado";
                        rdoAltB.Text = "B. Doutor Destino";
                        rdoAltC.Text = "C. Coisa";
                        rdoAltD.Text = "D. Senhor Fantástico";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 8:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Senhor Fantástico");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 9 - Quantos Heróis Lutaram em" + " \n" + "'Capitão América: Guerra Civil?";
                        rdoAltA.Text = "A. 10";
                        rdoAltB.Text = "B. 12";
                        rdoAltC.Text = "C. 14";
                        rdoAltD.Text = "D. 16";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 9:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. 12");
                        }

                        labelcont.Text = acertos.ToString();
                        quest1++;

                        labelquest.Text = "Questão 10 - Qual foi o primeiro Herói" + " \n" + "criado pela Marvel?";
                        rdoAltA.Text = "A. Homem - Aranha";
                        rdoAltB.Text = "B. Demolidor";
                        rdoAltC.Text = "C. Hulk";
                        rdoAltD.Text = "D. Namor";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 10:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                            MessageBox.Show("Quiz finalizado!" + " \n" + " - Você teve " + acertos.ToString() + " Acertos");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Namor");
                            MessageBox.Show("Quiz finalizado!" + " \n" + " - Você teve " + acertos.ToString() + " Acertos");
                        }
                        labelcont.Text = acertos.ToString();
                        quest1 = 0; 
                        break;
                }
            }

            /////////////////////////////////STAR WARS/////////////////////////////////
            
            else if (comboBox.SelectedItem == "STAR WARS")

            {
                switch (quest2)
                {
                    case 1:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. Léia");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 2 - Quem criou Star Wars?";
                        rdoAltA.Text = "A. George Lucas";
                        rdoAltB.Text = "B. Steven Spielberg";
                        rdoAltC.Text = "C. Walt Disney";
                        rdoAltD.Text = "D. Quentin Tarantino";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 2:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. George Lucas");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 3 - Em qual filme Nasceu Darth Vader?";
                        rdoAltA.Text = "A. III";
                        rdoAltB.Text = "B. IV";
                        rdoAltC.Text = "C. II";
                        rdoAltD.Text = "D. VI";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 3:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. III");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 4 - Qual o planeta natal da" + " \n" + " Familia Skywalker?";
                        rdoAltA.Text = "A. Naboo";
                        rdoAltB.Text = "B. Tatooine";
                        rdoAltC.Text = "C. Alderaan";
                        rdoAltD.Text = "D. Dagobah";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 4:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. Tatooine");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 5 - Quem foi a esposa de" + " \n" + " Anakin Skywalker?";
                        rdoAltA.Text = "A. Léia Organa";
                        rdoAltB.Text = "B. Ahsoka";
                        rdoAltC.Text = "C. Mom Mothma";
                        rdoAltD.Text = "D. Padmé Amidala";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 5:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Padmé Amidala");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 6 - Quem Anakin ataca para" + " \n" + " salvar o emperador Palpatine?";
                        rdoAltA.Text = "A. Chanceler";
                        rdoAltB.Text = "B. Obi-Wan";
                        rdoAltC.Text = "C. Mace Windu";
                        rdoAltD.Text = "D. Darth Vader";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;


                    ////////////////////////////

                    case 6:
                        if (rdoAltC.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: C. Mace Windu");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 7 - Quem é Darth Vader?";
                        rdoAltA.Text = "A. Luke";
                        rdoAltB.Text = "B. Chanceler";
                        rdoAltC.Text = "C. Obi-Wan";
                        rdoAltD.Text = "D. Anakin Skywalker";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;


                    ////////////////////////////

                    case 7:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Anakin Skywalker");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 8 - Qual o Planeta natal de Han Solo?";
                        rdoAltA.Text = "A. Bespin";
                        rdoAltB.Text = "B. Endor";
                        rdoAltC.Text = "C. Corellía";
                        rdoAltD.Text = "D. Hoth";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 8:
                        if (rdoAltC.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: C. Corellía");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 9 - C3PO é fluente em quantas" + " \n" + " formas de comunicação?";
                        rdoAltA.Text = "A. 3 milhões";
                        rdoAltB.Text = "B. 6 milhões";
                        rdoAltC.Text = "C. 10 milhões";
                        rdoAltD.Text = "D. 2 milhões";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 9:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. 6 milhões");
                        }

                        labelcont.Text = acertos.ToString();
                        quest2++;

                        labelquest.Text = "Questão 10 - Qual o nome da nave de Han Solo?";
                        rdoAltA.Text = "A. Tie executor";
                        rdoAltB.Text = "B. Cruzador";
                        rdoAltC.Text = "C. Razor Crest";
                        rdoAltD.Text = "D. Millenium Falcon";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;


                    ////////////////////////////


                    case 10:

                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                            MessageBox.Show("Quiz finalizado!" + " \n" + " - Você teve " + acertos.ToString() + " Acertos");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Millenium Falcon");
                            MessageBox.Show("Quiz finalizado!" + " \n" + " - Você teve " + acertos.ToString() + " Acertos");
                        }
                        labelcont.Text = acertos.ToString();
                        quest2 = 0; 
                        break;
                   
                }
            }

            /////////////////////////////////DC COMICS/////////////////////////////////
            
            
            else if (comboBox.SelectedItem == "DC COMICS")
            {
                switch (quest3)
                {
                    case 1:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Kal-El");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 2 - Quem matou os pais do Batman?";
                        rdoAltA.Text = "A. Pinguim";
                        rdoAltB.Text = "B. Joe Chill";
                        rdoAltC.Text = "C. Coringa";
                        rdoAltD.Text = "D. Um Morcego";
                        rdoAltNada.Text = "Nenhuma das Anteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 2:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. Joe Chill");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 3 - O que dá Poderes ao Superman?";
                        rdoAltA.Text = "A. Sol Vermelho";
                        rdoAltB.Text = "B. Criptonita";
                        rdoAltC.Text = "C. Raio";
                        rdoAltD.Text = "D. Sol Amarelo";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 3:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Sol Amarelo");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 4 - Qual desses Personagens tem Poderes?";
                        rdoAltA.Text = "A. Coringa";
                        rdoAltB.Text = "B. Ra's al ghul";
                        rdoAltC.Text = "C. Senhor Incrível";
                        rdoAltD.Text = "D. Batman";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 4:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. Ra's al ghul");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 5 - Quem é o Flash mais rápido?";
                        rdoAltA.Text = "A. Flash ( Barry Allen )";
                        rdoAltB.Text = "B. Flash Reverso";
                        rdoAltC.Text = "C. Godspeed";
                        rdoAltD.Text = "D. Flash ( Wooley West )";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 5:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Flash ( Wooley West )");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 6 - Quem é o 'Protetor' de Kahndaq?";
                        rdoAltA.Text = "A. Adão Negro";
                        rdoAltB.Text = "B. Senhor Destino";
                        rdoAltC.Text = "C. Caçador de Marte";
                        rdoAltD.Text = "D. Shazan";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;


                    ////////////////////////////

                    case 6:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. Adão Negro");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Quem é responsável pela morte" + " \n" + "do Superman ?";
                        rdoAltA.Text = "A. Lex Luthor";
                        rdoAltB.Text = "B. Apocalipse (Doomsday)";
                        rdoAltC.Text = "C. Darkseid";
                        rdoAltD.Text = "D. Batman";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;


                    ////////////////////////////

                    case 7:
                        if (rdoAltB.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: B. Apocalipse (Doomsday)");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 8 - Em que ano a DC Comics foi Fundada?";
                        rdoAltA.Text = "A. 1934";
                        rdoAltB.Text = "B. 1936";
                        rdoAltC.Text = "C. 1937";
                        rdoAltD.Text = "D. 1940";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 8:
                        if (rdoAltA.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: A. 1934");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 9 - O que Darkseid procura" + " \n" + "incessantemente pelo Universo?";
                        rdoAltA.Text = "A. Caixas maternas para formar a unidade";
                        rdoAltB.Text = "B. O Superman";
                        rdoAltC.Text = "C. Manopla do Infinito";
                        rdoAltD.Text = "D. Equação Anti - Vida";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;

                    ////////////////////////////

                    case 9:
                        if (rdoAltD.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: D. Equação Anti - Vida");
                        }

                        labelcont.Text = acertos.ToString();
                        quest3++;

                        labelquest.Text = "Questão 10 - Onde é o planeta natal do Superman?";
                        rdoAltA.Text = "A. Metropolis";
                        rdoAltB.Text = "B. Gothan";
                        rdoAltC.Text = "C. Krypton";
                        rdoAltD.Text = "D. Galactic";
                        rdoAltNada.Text = "Nenhuma das Alteriores";
                        rdoAltNada.Checked = true;
                        break;


                    ////////////////////////////

                    case 10:

                        if (rdoAltC.Checked)
                        {
                            acertos++;
                            MessageBox.Show("Acertou");
                            MessageBox.Show("Quiz finalizado!" + " \n" + " - Você teve " + acertos.ToString() + " Acertos");
                        }
                        else
                        {
                            MessageBox.Show("Errou!" + " \n" + "Resposta certa: C. Krypton");
                            MessageBox.Show("Quiz finalizado!" + " \n" + " - Você teve " + acertos.ToString() + " Acertos");
                        }
                        labelcont.Text = acertos.ToString();
                        quest3 = 0; 
                        break;

                }
            }
        }
       
        private void rdoAltA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAltB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAltC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAltD_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

