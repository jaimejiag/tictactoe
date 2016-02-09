using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class frmPrincipal : Form
    {
        const int MAX_FILAS_COLUMNAS = 3;
        const int VACIO = 0;
        Casilla[,] tablero = new Casilla[MAX_FILAS_COLUMNAS, MAX_FILAS_COLUMNAS];
        int jugador = 0;
        int contadorPartida = 0;
        int contadorJugador1 = 0;
        int contadorJugador2 = 0;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Ganador()
        {
            string cabecera = "Ganador";
            string texto = "Ha ganado el jugador " + jugador.ToString();
            MessageBox.Show(texto, cabecera);

            if (jugador == 1)
            {
                contadorJugador1++;
                lblPuntos1.Text = contadorJugador1.ToString();
            }
            else
            {
                contadorJugador2++;
                lblPuntos2.Text = contadorJugador2.ToString();
            }

            LimpiarImagenes();
        }

        private void LimpiarImagenes()
        {
            for (int k = 0; k < panelCasillas.Controls.Count; k++)
            {
                ((PictureBox)panelCasillas.Controls[k]).Image = null;
                ((PictureBox)panelCasillas.Controls[k]).Enabled = false;
                ((PictureBox)panelCasillas.Controls[k]).BackColor = Color.WhiteSmoke;
            }
        }

        private void ComprobarEmpate()
        {
            if (++contadorPartida == 9)
            {
                MessageBox.Show("Empate");
                LimpiarImagenes();
            }
        }

        private bool HayVictoria()
        {
            //Casillas horizontales
            //---------------------------------------------------------------------------------------------
            if (tablero[0, 0].Estado == tablero[0, 1].Estado && tablero[0, 1].Estado == tablero[0, 2].Estado)
                return true;

            if (tablero[1, 0].Estado == tablero[1, 1].Estado && tablero[1, 1].Estado == tablero[1, 2].Estado)
                return true;

            if (tablero[2, 0].Estado == tablero[2, 1].Estado && tablero[2, 1].Estado == tablero[2, 2].Estado)
                return true;

            //Casilla verticales
            //---------------------------------------------------------------------------------------------

            if (tablero[0, 0].Estado == tablero[1, 0].Estado && tablero[1, 0].Estado == tablero[2, 0].Estado)
                return true;

            if (tablero[0, 1].Estado == tablero[1, 1].Estado && tablero[1, 1].Estado == tablero[2, 1].Estado)
                return true;

            if (tablero[0, 2].Estado == tablero[1, 2].Estado && tablero[1, 2].Estado == tablero[2, 2].Estado)
                return true;

            //Casilla en ángulo
            //---------------------------------------------------------------------------------------------

            if (tablero[0, 0].Estado == tablero[1, 1].Estado && tablero[1, 1].Estado == tablero[2, 2].Estado)
                return true;

            if (tablero[0, 2].Estado == tablero[1, 1].Estado && tablero[1, 1].Estado == tablero[2, 0].Estado)
                return true;
            else
                return false;
        }


        private void picBox1_Click(object sender, EventArgs e)
        {
            tablero[0, 0].Estado = jugador;
            picBox1.Image = tablero[0, 0].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            tablero[0, 1].Estado = jugador;
            picBox2.Image = tablero[0, 1].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            tablero[0, 2].Estado = jugador;
            picBox3.Image = tablero[0, 2].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            tablero[1, 0].Estado = jugador;
            picBox4.Image = tablero[1, 0].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox5_Click(object sender, EventArgs e)
        {
            tablero[1, 1].Estado = jugador;
            picBox5.Image = tablero[1, 1].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox6_Click(object sender, EventArgs e)
        {
            tablero[1, 2].Estado = jugador;
            picBox6.Image = tablero[1, 2].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox7_Click(object sender, EventArgs e)
        {
            tablero[2, 0].Estado = jugador;
            picBox7.Image = tablero[2, 0].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox8_Click(object sender, EventArgs e)
        {
            tablero[2, 1].Estado = jugador;
            picBox8.Image = tablero[2, 1].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void picBox9_Click(object sender, EventArgs e)
        {
            tablero[2, 2].Estado = jugador;
            picBox9.Image = tablero[2, 2].GetImagen();

            if (HayVictoria())
                Ganador();
            else
            {
                if (jugador == 1)
                    jugador = 2;
                else
                    jugador = 1;

                lblTurno.Text = "Jugador " + jugador.ToString();
            }

            ComprobarEmpate();
        }

        private void btnPartidaNueva_Click(object sender, EventArgs e)
        {
            int noRepeticion = 3;

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = new Casilla(noRepeticion++);
                }
            }

            for (int k = 0; k < panelCasillas.Controls.Count; k++)
            {
                ((PictureBox)panelCasillas.Controls[k]).Enabled = true;
                ((PictureBox)panelCasillas.Controls[k]).BackColor = Color.White;
            }

            jugador = 1;
            lblTurno.Text = "Jugador " + jugador.ToString();
            contadorPartida = 0;
        }
    }
}
