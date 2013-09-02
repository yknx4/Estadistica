using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            datos = new List<Double>();
            Moda = new List<double>();
        }

        

        
        void llenarTabla()
        {
            /*Limpieza de la tabla*/
            dtgrTabla.Rows.Clear();
            dtgrTabla.Rows.Insert(0, numeroClaseRedondead());

            /*Codigo para llenar la tabla*/
            int intervaloClase = (int)datos.First();
            int frecuenciaAcumulada = 0;
            int numeroClaseRedondeado = numeroClaseRedondead();
            for (int i = 0; i < numeroClaseRedondeado;i++ )
            {
                
                /*Marcas de Clase*/
                dtgrTabla[0, i].Value = (i + 1).ToString();
                /*Intervalos de Clase*/
                int intervaloInicial = intervaloClase;
                intervaloClase += (int)Math.Round(intClase, MidpointRounding.AwayFromZero);
                dtgrTabla[1,i].Value = intervaloInicial.ToString() + " - " + intervaloClase.ToString();
                
                /*Frecuencia*/
                int frecuencia=0;
                foreach (double dato in datos)
                {
                    if (dato > intervaloClase) break;
                    if (dato >= intervaloInicial) frecuencia++;
                }
                dtgrTabla[2, i].Value = frecuencia.ToString();

                /*Frecuencia Acumulada*/
                frecuenciaAcumulada += frecuencia;
                dtgrTabla[3, i].Value = frecuenciaAcumulada.ToString();

                /*Frecuencia Relativa*/
                double frecuenciaRelativa = (double)frecuencia / (double)cantidadDatos();
                //MessageBox.Show(frecuencia.ToString() +" "+cantidadDatos().ToString());
                dtgrTabla[4, i].Value = Math.Round(frecuenciaRelativa,3).ToString();

                /*frecuenciaRelativaAcumulada*/
                double frecuenciaRelativaAcumulada = (double)frecuenciaAcumulada / (double)cantidadDatos();
                dtgrTabla[5, i].Value = Math.Round(frecuenciaRelativaAcumulada, 3).ToString();

                /*Marca de Clase*/
                double marcaDeClase = ((double)(intervaloClase + intervaloInicial))/2;
                dtgrTabla[6, i].Value = Math.Round(marcaDeClase, 3).ToString();

                /*Grados*/
                double grados = ((double)(360 * frecuencia)) / cantidadDatos();
                dtgrTabla[7, i].Value = Math.Round(grados, 3).ToString();

                /*Acomodar para el siguiente registro*/
                intervaloClase++;
            }
        }
        void calcularPromedio()
        {
            double suma = 0;
            foreach (double value in datos)
            {
                suma += value;
            }
            promedio = suma / cantidadDatos();
            lblPromedio.Text = Math.Round(promedio,3).ToString();
        }
        void calcularNumeroDeClase()
        {
            int cantidadDeDatos = cantidadDatos();
            if (cantidadDeDatos<50)
            {
                numeroClase = 1 + 3.3*Math.Log10(cantidadDeDatos);
            } 
            else
            {
                numeroClase = 3 + 3.3 * Math.Log10(cantidadDeDatos);
            }
            lblNoClase.Text = Math.Round(numeroClase, 3).ToString() + " ~ " + Math.Round(numeroClase, MidpointRounding.AwayFromZero).ToString();
        }
        void calcularModa()
        {
            lblModa.Text = "Aqui iría la moda... si tuviera una";
        }
        void calcularVarianza()
        {
            double temporal = 0;
            foreach(double dato in datos){
                temporal += Math.Pow(dato - promedio, 2);
            }
            varianza = temporal / (cantidadDatos() - 1);
            desvEstandar = Math.Sqrt(varianza);
            lblVarianza.Text = Math.Round(varianza, 3).ToString();
            lblDesvEsta.Text = Math.Round(desvEstandar, 3).ToString();

        }
        void calcularIntervaloDeClase()
        {
            /*lblMediana.Text = datos.First().ToString();
            lblModa.Text = datos.Last().ToString();*/
            intClase = (datos.Last() - datos.First()) / ((int)Math.Round(numeroClase, MidpointRounding.AwayFromZero));
            lblIntClase.Text = Math.Round(intClase, 3).ToString() + " ~ " + Math.Round(intClase, MidpointRounding.AwayFromZero).ToString();
        }
        void calcularMediana()
        {
            int numeroDeDatos = cantidadDatos();
            if (numeroDeDatos==1)
            {
                Mediana = datos.First();
                lblMediana.Text = Mediana.ToString();
                return;
            }
            if (numeroDeDatos%2 == 0)
            {
                Mediana = (datos[(numeroDeDatos / 2)-1] + datos[(numeroDeDatos / 2)])/2;
            }
            else{
                Mediana = datos[((numeroDeDatos - 1) / 2)];
            }
            lblMediana.Text = Mediana.ToString();
        }
        int cantidadDatos()
        {
            return dtgrDatos.RowCount-1;
        }

        void refreshData()
        {
            datos.Clear();
            double valor;
            for (int i = 0; i < cantidadDatos(); i++)
            {
                valor = Double.Parse(dtgrDatos[0, i].FormattedValue.ToString());
                datos.Add(valor);
            }
            datos.Sort();
        }

        List<Double> datos;
        double numeroClase;
        double intClase;
        double varianza;
        double promedio;
        double desvEstandar;
        double Mediana;
        List<double> Moda;

        private void validarDato(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dtgrDatos.Rows[e.RowIndex].ErrorText = "";
            
            double newInteger;

            // Don't try to validate the 'new row' until finished 
            // editing since there
            // is not any point in validating its initial value.
            if (dtgrDatos.Rows[e.RowIndex].IsNewRow) { return; }
            if (!double.TryParse(e.FormattedValue.ToString(),
                out newInteger) )
            {
                e.Cancel = true;
                dtgrDatos.Rows[e.RowIndex].ErrorText = "the value must be a number";
            }
        }


        void rehacer()
        {
            if (cantidadDatos() == 0) return;

            refreshData();
            calcularPromedio();
            calcularNumeroDeClase();
            calcularIntervaloDeClase();
            calcularMediana();
            calcularModa();
            calcularVarianza();
            llenarTabla();
        }

        private int numeroClaseRedondead()
        {
            return (int)(Math.Round(numeroClase, MidpointRounding.AwayFromZero));
        }
        private void cuandoDatosCambian(object sender, DataGridViewRowsAddedEventArgs e)
        {
           // rehacer();
        }

        private void cuandoDatosCambian(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rehacer();
        }

        private void cuandoValorCambia(object sender, DataGridViewCellEventArgs e)
        {
            rehacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dtgrDatos.SelectedRows)
            {
                if(!dr.IsNewRow)dtgrDatos.Rows.Remove(dr);
            }
        }
    }
}
