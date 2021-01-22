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

            ha_finalizado();
        }

        public bool ha_finalizado()
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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Bombilla1_Click(object sender, EventArgs e)
        {

        }

        private void iniciarJuego_Click(object sender, EventArgs e)
        {
            elegir_palabra();
            MessageBox.Show(palabra_elegida);
            
            for(int i = 0; i < array_vacio.Length; i++)
            {
                rich_palabraSecreta.Text += array_vacio[i] + "  ";
            }
        }

        
        private void buttonA_Click(object sender, EventArgs e)
        {
            comprobar_letra('A');
            buttonA.BackColor = Color.DimGray;
        }
    }
}
