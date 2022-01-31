using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3Guia1LabPED
{
    public partial class Form1 : Form
    {

        Graphics area; //Área de trabajo
        public Form1()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics(); //establezco el área de dibujo para el picturebox
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black); //color por defecto
            
            switch(cmbcolor.SelectedIndex) //colorear dependiendo de lo selecionado en ComboBox
            {
            case 0: lapicero = new Pen(Color.Yellow); break; //seleccion amarilla
            case 1: lapicero = new Pen(Color.Red); break; //seleccion roja
            case 2: lapicero = new Pen(Color.Blue); break; //seleccion azul
            case 3: lapicero = new Pen(Color.Black); break; //seleccion negra
            }

            int iteraciones = int.Parse(txtcantidad.Text); //cantidad de lineas a dibujar
            int espacio = int.Parse(txtespaciado.Text); //espaciado asignado (en pixeles)

            area.Clear(Color.White); //limpia área a blanco, para que lineas no se vean una sobre otra
            //int puntoinicio = 50; //inicio en un valor y = 50

            int puntoinicio = int.Parse(txtinicio.Text);
            int puntotermina = int.Parse(txttermina.Text);

            for(int i=0; i < iteraciones; i++)
            {
                area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntotermina + (espacio * i));
                //dibuja linea por linea de acuerdo al color dado, en "x" van de 20 a 300 y en "Y" varia segun su iteracion
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
