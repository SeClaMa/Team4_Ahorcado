using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        string[] listado_palabras = { "ZANAHORIA","CHANCLETA","MANDO","ORNITORRINCO","PANFLETO","BONIATO","PAPANATAS","PILTRAFILLA","CABEZON","MANZANA","PERRO","GATO"};
        string palabra_elegida;
        char[] palabra_separada;
        char[] array_vacio;
        int contador_fallos = 0;
        bool finalizado_juego = false;
        bool pista_dada = false;

        public void elegir_palabra()
        {
            Random aleatorio = new Random();
            palabra_elegida = listado_palabras[aleatorio.Next(1,listado_palabras.Length)];
            array_vacio = new char[palabra_elegida.Length];
            palabra_separada = new char[palabra_elegida.Length];
            for (int i = 0; i < palabra_elegida.Length; i++)
            {
                palabra_separada[i]=palabra_elegida[i];
                array_vacio[i] = '_';
            }
            
        }
        public void comprobar_letra(char letra)
        {
            bool encontrado = false;
            for(int i = 0; i < palabra_elegida.Length; i++)
            {
                if (letra == palabra_elegida[i])
                {
                    array_vacio[i] = letra;
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                contador_fallos++;
            }

            rich_palabraSecreta.Text = "";

            for (int i = 0; i < array_vacio.Length; i++)
            {
                rich_palabraSecreta.Text += array_vacio[i] + "  ";
            }

            cambiarImagenes();

            if (Ha_finalizado())
            {
                MessageBox.Show("Has ganado con " + contador_fallos + " fallos");
                finalizado_juego = true;
            }

            if (contador_fallos == 6)
            {
                MessageBox.Show("Has perdido el juego porque has llegado a 6 fallos la palabra era " + palabra_elegida);
                finalizado_juego = true;
            }
        }

        public void cambiarImagenes()
        {
            if(contador_fallos == 0)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado1;
            }

            else if (contador_fallos == 1)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado2;
            }

            else if (contador_fallos == 2)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado3;
            }

            else if (contador_fallos == 3)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado4;
            }

            else if (contador_fallos == 4)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado5;
            }

            else if (contador_fallos == 5)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado6;
            }

            else if (contador_fallos == 6)
            {
                picture_Ahorcado.Image = Ahorcado.Properties.Resources.Ahorcado7;
            }
        }

        public void Pista()
        {

            for (int i = 0; i < palabra_separada.Length; i++)
            {
                if (array_vacio[i] == '_' && !pista_dada)
                {
                    array_vacio[i] = palabra_separada[i];
                    pista_dada = true;
                }
            }

            rich_palabraSecreta.Text = "";

            for (int i = 0; i < array_vacio.Length; i++)
            {
                rich_palabraSecreta.Text += array_vacio[i] + "  ";
            }

            contador_fallos++;

            cambiarImagenes();

        }

        public bool Ha_finalizado()
        {
            for (int i = 0; i < array_vacio.Length; i++)
            {
                if (array_vacio[i] == '_')
                {
                    return false;
                }
            }
            return true;
        }

        public void ReiniciarColorButton()
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            buttonE.BackColor = Color.White;
            buttonF.BackColor = Color.White;
            buttonG.BackColor = Color.White;
            buttonH.BackColor = Color.White;
            buttonI.BackColor = Color.White;
            buttonJ.BackColor = Color.White;
            buttonK.BackColor = Color.White;
            buttonL.BackColor = Color.White;
            buttonM.BackColor = Color.White;
            buttonN.BackColor = Color.White;
            buttonÑ.BackColor = Color.White;
            buttonO.BackColor = Color.White;
            buttonP.BackColor = Color.White;
            buttonQ.BackColor = Color.White;
            buttonR.BackColor = Color.White;
            buttonS.BackColor = Color.White;
            buttonT.BackColor = Color.White;
            buttonU.BackColor = Color.White;
            buttonV.BackColor = Color.White;
            buttonW.BackColor = Color.White;
            buttonX.BackColor = Color.White;
            buttonY.BackColor = Color.White;
            buttonZ.BackColor = Color.White;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void iniciarJuego_Click(object sender, EventArgs e)
        {
            pista_dada = false;
            finalizado_juego = false;
            elegir_palabra();
            //MessageBox.Show(palabra_elegida);
            contador_fallos = 0;

            rich_palabraSecreta.Text = "";

            for(int i = 0; i < array_vacio.Length; i++)
            {
                rich_palabraSecreta.Text += array_vacio[i] + "  ";
            }

            cambiarImagenes();
            ReiniciarColorButton();
        }

        #region Button_click
        private void buttonA_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('A');
                buttonA.BackColor = Color.DimGray;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('B');
                buttonB.BackColor = Color.DimGray;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('C');
                buttonC.BackColor = Color.DimGray;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('D');
                buttonD.BackColor = Color.DimGray;
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('E');
                buttonE.BackColor = Color.DimGray;
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('F');
                buttonF.BackColor = Color.DimGray;
            }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('G');
                buttonG.BackColor = Color.DimGray;
            }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('H');
                buttonH.BackColor = Color.DimGray;
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('I');
                buttonI.BackColor = Color.DimGray;
            }
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('J');
                buttonJ.BackColor = Color.DimGray;
            }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('K');
                buttonK.BackColor = Color.DimGray;
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('L');
                buttonL.BackColor = Color.DimGray;
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('M');
                buttonM.BackColor = Color.DimGray;
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('N');
                buttonN.BackColor = Color.DimGray;
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('U');
                buttonU.BackColor = Color.DimGray;
            }
        }
        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('Q');
                buttonQ.BackColor = Color.DimGray;
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('S');
                buttonS.BackColor = Color.DimGray;
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('R');
                buttonR.BackColor = Color.DimGray;
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('T');
                buttonT.BackColor = Color.DimGray;
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('P');
                buttonP.BackColor = Color.DimGray;
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('O');
                buttonO.BackColor = Color.DimGray;
            }
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('Ñ');
                buttonÑ.BackColor = Color.DimGray;
            }
        }
        private void buttonV_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('V');
                buttonV.BackColor = Color.DimGray;
            }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('W');
                buttonW.BackColor = Color.DimGray;
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('X');
                buttonX.BackColor = Color.DimGray;
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('Y');
                buttonY.BackColor = Color.DimGray;
            }
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                comprobar_letra('Z');
                buttonZ.BackColor = Color.DimGray;
            }
        }
        #endregion

        #region Bombilla_click
        private void Bombilla1_Click(object sender, EventArgs e)
        {

            if (!pista_dada)
            {
                Pista();
                Bombilla1.Visible = false;
            }
        }
        private void Bombilla2_Click(object sender, EventArgs e)
        {
            if (!pista_dada)
            {
                Pista();
                Bombilla2.Visible = false;
            }
        }

        private void Bombilla3_Click(object sender, EventArgs e)
        {
            if (!pista_dada)
            {
                Pista();
                Bombilla3.Visible = false;
            }
        }

        private void Bombilla4_Click(object sender, EventArgs e)
        {
            if (!pista_dada)
            {
                Pista();
                Bombilla4.Visible = false;
            }
        }

        private void Bombilla5_Click(object sender, EventArgs e)
        {
            if (!pista_dada)
            {
                Pista();
                Bombilla5.Visible = false;
            }
        }

        #endregion

        private void resolver_Click(object sender, EventArgs e)
        {
            if (!finalizado_juego)
            {
                rich_palabraSecreta.Text = "";

                for (int i = 0; i < palabra_separada.Length; i++)
                {
                    rich_palabraSecreta.Text += palabra_separada[i] + "  ";
                }

                finalizado_juego = true;
            }
        }
    }
}
