using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac4Perceptron
{
    public partial class Form1 : Form
    {
          operaciones cuatroentradas = new operaciones(4,0.8d); //Se usa otro objeto de 4 entradas para Paridad

        bool VF = false;//Inicia la variable VErdad o Falso de tipo boolenao
        DataTable tabla = new DataTable();
        DataSet datoesp = new DataSet();
        public Form1()
        {
            InitializeComponent();

            //Este es el codigo para mstrar los datos del archivo .data
            string[] iris = new string[150];
            StreamReader leer = new StreamReader(@"iris.data");
            for (int i = 0; i < iris.Length; i++)
            {
                iris[i] = leer.ReadLine();
                lBDatosiris.Items.Add(iris[i]);
            }
            leer.Close();//hasta aquí
         }
        public void tabladedatos()
        {
            DataColumn x1 = new DataColumn("X1");
            DataColumn x2 = new DataColumn("X2");
            DataColumn x3 = new DataColumn("X3");
            DataColumn x4 = new DataColumn("X4");
            DataColumn yesp = new DataColumn("Yesp");
            DataColumn yobt = new DataColumn("Yobt");
            //DataColumn yobt = new DataColumn("Yobt");
            tabla.Columns.Add(x1);
            tabla.Columns.Add(x2);
            tabla.Columns.Add(x3);
            tabla.Columns.Add(x4);
            tabla.Columns.Add(yesp);
            tabla.Columns.Add(yobt);

            Gridtabla.DataSource = tabla;
        }
        private void Bt1_Click(object sender, EventArgs e)
        {

            if (Problema.Text=="SETOSA_VERSICOLOR")
            {
                SETOSA_VERSICOLOR();
                tabladedatos();
                string[] iris = File.ReadAllLines(@"iris.data");
                string[] datos;
                int contador = 0;
                //for (int i = 0; i<iris.Length; i++)
                for (int i = 0; i<100; i++)
                {
                    datos = iris[i].ToString().Split(',');
                    string[] row = new string[datos.Length+1];
                    // contador++;
                    for (int j = 0; j <datos.Length; j++)
                    {
                        row[j] = datos[j].Trim();
                    }
                    if (++contador <51)
                    {
                        row[4]="-1";
                     }
                    else
                    {
                        row[4] = "1";
                     }
                    tabla.Rows.Add(row);
                }
                #region SETOSA VERSICOLOR
                //SETOSA
                Gridtabla.Rows[0].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.2 });
                Gridtabla.Rows[1].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.0, 1.4, 0.2 });
                Gridtabla.Rows[2].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.3, 0.2 });
                Gridtabla.Rows[3].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.1, 1.5, 0.2 });
                Gridtabla.Rows[4].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.6, 1.4, 0.2 });
                Gridtabla.Rows[5].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.7, 0.4 });
                Gridtabla.Rows[6].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.4, 1.4, 0.3 });
                Gridtabla.Rows[7].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.5, 0.2 });
                Gridtabla.Rows[8].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.4, 2.9, 1.4, 0.2 });
                Gridtabla.Rows[9].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 });
                Gridtabla.Rows[10].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.7, 1.5, 0.2 });
                Gridtabla.Rows[11].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.6, 0.2 });
                Gridtabla.Rows[12].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.1 });
                Gridtabla.Rows[13].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.3, 3.0, 1.1, 0.1 });
                Gridtabla.Rows[14].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 4.0, 1.2, 0.2 });
                Gridtabla.Rows[15].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 4.4, 1.5, 0.4 });
                Gridtabla.Rows[16].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.3, 0.4 });
                Gridtabla.Rows[17].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.3 });
                Gridtabla.Rows[18].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 3.8, 1.7, 0.3 });
                Gridtabla.Rows[19].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.5, 0.3 });
                Gridtabla.Rows[20].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.7, 0.2 });
                Gridtabla.Rows[21].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.7, 1.5, 0.4 });
                Gridtabla.Rows[22].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.6, 1.0, 0.2 });
                Gridtabla.Rows[23].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.3, 1.7, 0.5 });
                Gridtabla.Rows[24].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.9, 0.2 });
                Gridtabla.Rows[25].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.0, 1.6, 0.2 });
                Gridtabla.Rows[26].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.6, 0.4 });
                Gridtabla.Rows[27].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 3.5, 1.5, 0.2 });
                Gridtabla.Rows[28].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 3.4, 1.4, 0.2 });
                Gridtabla.Rows[29].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.6, 0.2 });
                Gridtabla.Rows[30].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.1, 1.6, 0.2 });
                Gridtabla.Rows[31].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.5, 0.4 });
                Gridtabla.Rows[32].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 4.1, 1.5, 0.1 });
                Gridtabla.Rows[33].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 4.2, 1.4, 0.2 });
                Gridtabla.Rows[34].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 });
                Gridtabla.Rows[35].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.2, 1.2, 0.2 });
                Gridtabla.Rows[36].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 3.5, 1.3, 0.2 });
                Gridtabla.Rows[37].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 });
                Gridtabla.Rows[38].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.4, 3.0, 1.3, 0.2 });
                Gridtabla.Rows[39].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.4, 1.5, 0.2 });
                Gridtabla.Rows[40].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.3, 0.3 });
                Gridtabla.Rows[41].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.5, 2.3, 1.3, 0.3 });
                Gridtabla.Rows[42].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.4, 3.2, 1.3, 0.2 });
                Gridtabla.Rows[43].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.6, 0.6 });
                Gridtabla.Rows[44].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.9, 0.4 });
                Gridtabla.Rows[45].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.3 });
                Gridtabla.Rows[46].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.6, 0.2 });
                Gridtabla.Rows[47].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.2, 1.4, 0.2 });
                Gridtabla.Rows[48].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.3, 3.7, 1.5, 0.2 });
                Gridtabla.Rows[49].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.3, 1.4, 0.2 });
                //VERSICOLOR
                Gridtabla.Rows[50].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.0, 3.2, 4.7, 1.4 });
                Gridtabla.Rows[51].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 4.5, 1.5 });
                Gridtabla.Rows[52].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 4.9, 1.5 });
                Gridtabla.Rows[53].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.3, 4.0, 1.3 });
                Gridtabla.Rows[54].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 2.8, 4.6, 1.5 });
                Gridtabla.Rows[55].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.5, 1.3 });
                Gridtabla.Rows[56].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 4.7, 1.6 });
                Gridtabla.Rows[57].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 2.4, 3.3, 1.0 });
                Gridtabla.Rows[58].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.6, 2.9, 4.6, 1.3 });
                Gridtabla.Rows[59].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 2.7, 3.9, 1.4 });
                Gridtabla.Rows[60].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 2.0, 3.5, 1.0 });
                Gridtabla.Rows[61].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 4.2, 1.5 });
                Gridtabla.Rows[62].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 4.0, 1.0 });
                Gridtabla.Rows[63].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.9, 4.7, 1.4 });
                Gridtabla.Rows[64].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.9, 3.6, 1.3 });
                Gridtabla.Rows[65].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.4, 1.4 });
                Gridtabla.Rows[66].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.5, 1.5 });
                Gridtabla.Rows[67].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 4.1, 1.0 });
                Gridtabla.Rows[68].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 2.2, 4.5, 1.5 });
                Gridtabla.Rows[69].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.5, 3.9, 1.1 });
                Gridtabla.Rows[70].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.9, 3.2, 4.8, 1.8 });
                Gridtabla.Rows[71].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.0, 1.3 });
                Gridtabla.Rows[72].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 4.9, 1.5 });
                Gridtabla.Rows[73].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.7, 1.2 });
                Gridtabla.Rows[74].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.9, 4.3, 1.3 });
                Gridtabla.Rows[75].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.6, 3.0, 4.4, 1.4 });
                Gridtabla.Rows[76].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.8, 2.8, 4.8, 1.4 });
                Gridtabla.Rows[77].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.0, 1.7 });
                Gridtabla.Rows[78].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.9, 4.5, 1.5 });
                Gridtabla.Rows[79].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.6, 3.5, 1.0 });
                Gridtabla.Rows[80].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.8, 1.1 });
                Gridtabla.Rows[81].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.7, 1.0 });
                Gridtabla.Rows[82].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 3.9, 1.2 });
                Gridtabla.Rows[83].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.7, 5.1, 1.6 });
                Gridtabla.Rows[84].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.0, 4.5, 1.5 });
                Gridtabla.Rows[85].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 3.4, 4.5, 1.6 });
                Gridtabla.Rows[86].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.7, 1.5 });
                Gridtabla.Rows[87].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.3, 4.4, 1.3 });
                Gridtabla.Rows[88].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.1, 1.3 });
                Gridtabla.Rows[89].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.5, 4.0, 1.3 });
                Gridtabla.Rows[90].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.6, 4.4, 1.2 });
                Gridtabla.Rows[91].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.6, 1.4 });
                Gridtabla.Rows[92].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.6, 4.0, 1.2 });
                Gridtabla.Rows[93].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 2.3, 3.3, 1.0 });
                Gridtabla.Rows[94].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.7, 4.2, 1.3 });
                Gridtabla.Rows[95].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 3.0, 4.2, 1.2 });
                Gridtabla.Rows[96].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.9, 4.2, 1.3 });
                Gridtabla.Rows[97].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 2.9, 4.3, 1.3 });
                Gridtabla.Rows[98].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 2.5, 3.0, 1.1 });
                Gridtabla.Rows[99].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.1, 1.3 });
#endregion
            }
            if (Problema.Text=="SETOSA_VIRGINICA")
            {
                SETOSA_VIRGINICA();
                tabladedatos();
                string[] iris = File.ReadAllLines(@"setosavirginica.data");
                string[] datos;
                int contador = 0;
                //for (int i = 0; i<iris.Length; i++)
                for (int i = 0; i<100; i++)
                {
                    datos = iris[i].ToString().Split(',');
                    string[] row = new string[datos.Length+1];
                    
                    for (int j = 0; j <datos.Length; j++)
                    {
                        row[j] = datos[j].Trim();
                    }
                    if (++contador <51)
                    {
                        row[4]="-1";
                    }
                    else
                    {
                        row[4] = "1";
                    }
                    tabla.Rows.Add(row);
                }
                #region SETOSA VIRGINICA
                //SETOSA
                Gridtabla.Rows[0].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.2 });
                Gridtabla.Rows[1].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.0, 1.4, 0.2 });
                Gridtabla.Rows[2].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.3, 0.2 });
                Gridtabla.Rows[3].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.1, 1.5, 0.2 });
                Gridtabla.Rows[4].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.6, 1.4, 0.2 });
                Gridtabla.Rows[5].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.7, 0.4 });
                Gridtabla.Rows[6].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.4, 1.4, 0.3 });
                Gridtabla.Rows[7].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.5, 0.2 });
                Gridtabla.Rows[8].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.4, 2.9, 1.4, 0.2 });
                Gridtabla.Rows[9].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 });
                Gridtabla.Rows[10].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.7, 1.5, 0.2 });
                Gridtabla.Rows[11].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.6, 0.2 });
                Gridtabla.Rows[12].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.1 });
                Gridtabla.Rows[13].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.3, 3.0, 1.1, 0.1 });
                Gridtabla.Rows[14].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 4.0, 1.2, 0.2 });
                Gridtabla.Rows[15].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 4.4, 1.5, 0.4 });
                Gridtabla.Rows[16].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.3, 0.4 });
                Gridtabla.Rows[17].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.3 });
                Gridtabla.Rows[18].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 3.8, 1.7, 0.3 });
                Gridtabla.Rows[19].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.5, 0.3 });
                Gridtabla.Rows[20].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.7, 0.2 });
                Gridtabla.Rows[21].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.7, 1.5, 0.4 });
                Gridtabla.Rows[22].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.6, 1.0, 0.2 });
                Gridtabla.Rows[23].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.3, 1.7, 0.5 });
                Gridtabla.Rows[24].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.9, 0.2 });
                Gridtabla.Rows[25].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.0, 1.6, 0.2 });
                Gridtabla.Rows[26].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.6, 0.4 });
                Gridtabla.Rows[27].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 3.5, 1.5, 0.2 });
                Gridtabla.Rows[28].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 3.4, 1.4, 0.2 });
                Gridtabla.Rows[29].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.6, 0.2 });
                Gridtabla.Rows[30].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.1, 1.6, 0.2 });
                Gridtabla.Rows[31].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.5, 0.4 });
                Gridtabla.Rows[32].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 4.1, 1.5, 0.1 });
                Gridtabla.Rows[33].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 4.2, 1.4, 0.2 });
                Gridtabla.Rows[34].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 });
                Gridtabla.Rows[35].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.2, 1.2, 0.2 });
                Gridtabla.Rows[36].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 3.5, 1.3, 0.2 });
                Gridtabla.Rows[37].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 });
                Gridtabla.Rows[38].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.4, 3.0, 1.3, 0.2 });
                Gridtabla.Rows[39].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.4, 1.5, 0.2 });
                Gridtabla.Rows[40].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.3, 0.3 });
                Gridtabla.Rows[41].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.5, 2.3, 1.3, 0.3 });
                Gridtabla.Rows[42].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.4, 3.2, 1.3, 0.2 });
                Gridtabla.Rows[43].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.6, 0.6 });
                Gridtabla.Rows[44].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.9, 0.4 });
                Gridtabla.Rows[45].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.3 });
                Gridtabla.Rows[46].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.6, 0.2 });
                Gridtabla.Rows[47].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.6, 3.2, 1.4, 0.2 });
                Gridtabla.Rows[48].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.3, 3.7, 1.5, 0.2 });
                Gridtabla.Rows[49].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 3.3, 1.4, 0.2 });
                //virginica
                Gridtabla.Rows[50].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 6.0, 2.5 });
                Gridtabla.Rows[51].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 });
                Gridtabla.Rows[52].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.1, 3.0, 5.9, 2.1 });
                Gridtabla.Rows[53].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.9, 5.6, 1.8 });
                Gridtabla.Rows[54].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.8, 2.2 });
                Gridtabla.Rows[55].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.6, 3.0, 6.6, 2.1 });
                Gridtabla.Rows[56].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 2.5, 4.5, 1.7 });
                Gridtabla.Rows[57].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.3, 2.9, 6.3, 1.8 });
                Gridtabla.Rows[58].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 2.5, 5.8, 1.8 });
                Gridtabla.Rows[59].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.2, 3.6, 6.1, 2.5 });
                Gridtabla.Rows[60].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.2, 5.1, 2.0 });
                Gridtabla.Rows[61].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.7, 5.3, 1.9 });
                Gridtabla.Rows[62].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.8, 3.0, 5.5, 2.1 });
                Gridtabla.Rows[63].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.5, 5.0, 2.0 });
                Gridtabla.Rows[64].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.8, 5.1, 2.4 });
                Gridtabla.Rows[65].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 5.3, 2.3 });
                Gridtabla.Rows[66].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.5, 1.8 });
                Gridtabla.Rows[67].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 3.8, 6.7, 2.2 });
                Gridtabla.Rows[68].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 2.6, 6.9, 2.3 });
                Gridtabla.Rows[69].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 5.0, 1.5 });
                Gridtabla.Rows[70].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.2, 5.7, 2.3 });
                Gridtabla.Rows[71].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.8, 4.9, 2.0 });
                Gridtabla.Rows[72].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 2.8, 6.7, 2.0 });
                Gridtabla.Rows[73].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.7, 4.9, 1.8 });
                Gridtabla.Rows[74].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.1 });
                Gridtabla.Rows[75].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.2, 3.2, 6.0, 1.8 });
                Gridtabla.Rows[76].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 2.8, 4.8, 1.8 });
                Gridtabla.Rows[77].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.9, 1.8 });
                Gridtabla.Rows[78].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.1 });
                Gridtabla.Rows[79].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.2, 3.0, 5.8, 1.6 });
                Gridtabla.Rows[80].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.4, 2.8, 6.1, 1.9 });
                Gridtabla.Rows[81].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.9, 3.8, 6.4, 2.0 });
                Gridtabla.Rows[82].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.2 });
                Gridtabla.Rows[83].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.8, 5.1, 1.5 });
                Gridtabla.Rows[84].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.6, 5.6, 1.4 });
                Gridtabla.Rows[85].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 3.0, 6.1, 2.3 });
                Gridtabla.Rows[86].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 3.4, 5.6, 2.4 });
                Gridtabla.Rows[87].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 3.1, 5.5, 1.8 });
                Gridtabla.Rows[88].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 3.0, 4.8, 1.8 });
                Gridtabla.Rows[89].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.4, 2.1 });
                Gridtabla.Rows[90].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 5.6, 2.4 });
                Gridtabla.Rows[91].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.1, 2.3 });
                Gridtabla.Rows[92].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 });
                Gridtabla.Rows[93].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.8, 3.2, 5.9, 2.3 });
                Gridtabla.Rows[94].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.5 });
                Gridtabla.Rows[95].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.2, 2.3 });
                Gridtabla.Rows[96].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 5.0, 1.9 });
                Gridtabla.Rows[97].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.2, 2.0 });
                Gridtabla.Rows[98].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 3.4, 5.4, 2.3 });
                Gridtabla.Rows[99].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 5.1, 1.8 });
                #endregion

            }
            if (Problema.Text=="VERSICOLOR_VIRGINICA")
            {
                VERSICOLOR_VIRGINICA();
                tabladedatos();
                string[] iris = File.ReadAllLines(@"versicolorvirginica.data");
                string[] datos;
                int contador = 0;
                //for (int i = 0; i<iris.Length; i++)
                for (int i = 0; i<100; i++)
                {
                    datos = iris[i].ToString().Split(',');
                    string[] row = new string[datos.Length+1];

                    for (int j = 0; j <datos.Length; j++)
                    {
                        row[j] = datos[j].Trim();
                    }
                    if (++contador <51)
                    {
                        row[4]="-1";
                    }else
                        {
                            row[4] = "1";
                        }
                    tabla.Rows.Add(row);
                }
                #region Salidacolumna5
                //VERSICOLOR
                Gridtabla.Rows[0].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.0, 3.2, 4.7, 1.4 });
                Gridtabla.Rows[1].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 4.5, 1.5 });
                Gridtabla.Rows[2].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 4.9, 1.5 });
                Gridtabla.Rows[3].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.3, 4.0, 1.3 });
                Gridtabla.Rows[4].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 2.8, 4.6, 1.5 });
                Gridtabla.Rows[5].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.5, 1.3 });
                Gridtabla.Rows[6].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 4.7, 1.6 });
                Gridtabla.Rows[7].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 2.4, 3.3, 1.0 });
                Gridtabla.Rows[8].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.6, 2.9, 4.6, 1.3 });
                Gridtabla.Rows[9].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.2, 2.7, 3.9, 1.4 });
                Gridtabla.Rows[10].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 2.0, 3.5, 1.0 });
                Gridtabla.Rows[11].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 4.2, 1.5 });
                Gridtabla.Rows[12].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 4.0, 1.0 });
                Gridtabla.Rows[13].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.9, 4.7, 1.4 });
                Gridtabla.Rows[14].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.9, 3.6, 1.3 });
                Gridtabla.Rows[15].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.4, 1.4 });
                Gridtabla.Rows[16].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.5, 1.5 });
                Gridtabla.Rows[17].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 4.1, 1.0 });
                Gridtabla.Rows[18].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 2.2, 4.5, 1.5 });
                Gridtabla.Rows[19].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.5, 3.9, 1.1 });
                Gridtabla.Rows[20].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.9, 3.2, 4.8, 1.8 });
                Gridtabla.Rows[21].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.0, 1.3 });
                Gridtabla.Rows[22].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 4.9, 1.5 });
                Gridtabla.Rows[23].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.7, 1.2 });
                Gridtabla.Rows[24].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.9, 4.3, 1.3 });
                Gridtabla.Rows[25].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.6, 3.0, 4.4, 1.4 });
                Gridtabla.Rows[26].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.8, 2.8, 4.8, 1.4 });
                Gridtabla.Rows[27].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.0, 1.7 });
                Gridtabla.Rows[28].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.9, 4.5, 1.5 });
                Gridtabla.Rows[29].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.6, 3.5, 1.0 });
                Gridtabla.Rows[30].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.8, 1.1 });
                Gridtabla.Rows[31].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.7, 1.0 });
                Gridtabla.Rows[32].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 3.9, 1.2 });
                Gridtabla.Rows[33].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.7, 5.1, 1.6 });
                Gridtabla.Rows[34].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.4, 3.0, 4.5, 1.5 });
                Gridtabla.Rows[35].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 3.4, 4.5, 1.6 });
                Gridtabla.Rows[36].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.7, 1.5 });
                Gridtabla.Rows[37].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.3, 4.4, 1.3 });
                Gridtabla.Rows[38].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.1, 1.3 });
                Gridtabla.Rows[39].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.5, 4.0, 1.3 });
                Gridtabla.Rows[40].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.5, 2.6, 4.4, 1.2 });
                Gridtabla.Rows[41].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.6, 1.4 });
                Gridtabla.Rows[42].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.6, 4.0, 1.2 });
                Gridtabla.Rows[43].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.0, 2.3, 3.3, 1.0 });
                Gridtabla.Rows[44].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.7, 4.2, 1.3 });
                Gridtabla.Rows[45].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 3.0, 4.2, 1.2 });
                Gridtabla.Rows[46].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.9, 4.2, 1.3 });
                Gridtabla.Rows[47].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 2.9, 4.3, 1.3 });
                Gridtabla.Rows[48].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.1, 2.5, 3.0, 1.1 });
                Gridtabla.Rows[49].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.1, 1.3 });
                //VIRGINICA
                Gridtabla.Rows[50].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 6.0, 2.5 });
                Gridtabla.Rows[51].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 });
                Gridtabla.Rows[52].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.1, 3.0, 5.9, 2.1 });
                Gridtabla.Rows[53].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.9, 5.6, 1.8 });
                Gridtabla.Rows[54].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.8, 2.2 });
                Gridtabla.Rows[55].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.6, 3.0, 6.6, 2.1 });
                Gridtabla.Rows[56].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 4.9, 2.5, 4.5, 1.7 });
                Gridtabla.Rows[57].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.3, 2.9, 6.3, 1.8 });
                Gridtabla.Rows[58].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 2.5, 5.8, 1.8 });
                Gridtabla.Rows[59].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.2, 3.6, 6.1, 2.5 });
                Gridtabla.Rows[60].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.2, 5.1, 2.0 });
                Gridtabla.Rows[61].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.7, 5.3, 1.9 });
                Gridtabla.Rows[62].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.8, 3.0, 5.5, 2.1 });
                Gridtabla.Rows[63].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.7, 2.5, 5.0, 2.0 });
                Gridtabla.Rows[64].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.8, 5.1, 2.4 });
                Gridtabla.Rows[65].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 5.3, 2.3 });
                Gridtabla.Rows[66].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.5, 1.8 });
                Gridtabla.Rows[67].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 3.8, 6.7, 2.2 });
                Gridtabla.Rows[68].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 2.6, 6.9, 2.3 });
                Gridtabla.Rows[69].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 5.0, 1.5 });
                Gridtabla.Rows[70].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.2, 5.7, 2.3 });
                Gridtabla.Rows[71].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.6, 2.8, 4.9, 2.0 });
                Gridtabla.Rows[72].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 2.8, 6.7, 2.0 });
                Gridtabla.Rows[73].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.7, 4.9, 1.8 });
                Gridtabla.Rows[74].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.1 });
                Gridtabla.Rows[75].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.2, 3.2, 6.0, 1.8 });
                Gridtabla.Rows[76].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 2.8, 4.8, 1.8 });
                Gridtabla.Rows[77].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.9, 1.8 });
                Gridtabla.Rows[78].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.1 });
                Gridtabla.Rows[79].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.2, 3.0, 5.8, 1.6 });
                Gridtabla.Rows[80].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.4, 2.8, 6.1, 1.9 });
                Gridtabla.Rows[81].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.9, 3.8, 6.4, 2.0 });
                Gridtabla.Rows[82].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.2 });
                Gridtabla.Rows[83].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.8, 5.1, 1.5 });
                Gridtabla.Rows[84].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.1, 2.6, 5.6, 1.4 });
                Gridtabla.Rows[85].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 7.7, 3.0, 6.1, 2.3 });
                Gridtabla.Rows[86].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 3.4, 5.6, 2.4 });
                Gridtabla.Rows[87].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.4, 3.1, 5.5, 1.8 });
                Gridtabla.Rows[88].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.0, 3.0, 4.8, 1.8 });
                Gridtabla.Rows[89].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.4, 2.1 });
                Gridtabla.Rows[90].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 5.6, 2.4 });
                Gridtabla.Rows[91].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.1, 2.3 });
                Gridtabla.Rows[92].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 });
                Gridtabla.Rows[93].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.8, 3.2, 5.9, 2.3 });
                Gridtabla.Rows[94].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.5 });
                Gridtabla.Rows[95].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.2, 2.3 });
                Gridtabla.Rows[96].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 5.0, 1.9 });
                Gridtabla.Rows[97].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.2, 2.0 });
                Gridtabla.Rows[98].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 6.2, 3.4, 5.4, 2.3 });
                Gridtabla.Rows[99].Cells[5].Value=cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 5.1, 1.8 });
                #endregion

            }
        }

        #region SETOSA-VERSICOLOR
        public void SETOSA_VERSICOLOR()
        {
            int counter = 0;
            while (!VF)
            {
                VF = true;
                lBsalida.Items.Add("\n--Epoca--: "+ ++counter);                
                lBsalida.Items.Add("W(0): "+cuatroentradas.Pesosiniciales[0]);
                lBsalida.Items.Add("W(1): "+cuatroentradas.Pesosiniciales[1]);
                lBsalida.Items.Add("W(2): "+cuatroentradas.Pesosiniciales[2]);
                lBsalida.Items.Add("W(3): "+cuatroentradas.Pesosiniciales[3]);
                lBsalida.Items.Add("Umbral θ: "+cuatroentradas.Umbralinicial);
                lBsalida.Items.Add(" \n ");

                #region SETOSA VERSICOLOR
                //setosa
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.5, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.0, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.0, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.7, 3.2, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.1, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.1, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.6, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.6, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.7, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.9, 1.7, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.4, 1.4, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.4, 1.4, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.4, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.4, 2.9, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.4, 2.9, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.7, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.7, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.4, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.0, 1.4, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.3, 3.0, 1.1, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.3, 3.0, 1.1, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 4.0, 1.2, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 4.0, 1.2, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 4.4, 1.5, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 4.4, 1.5, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.3, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.9, 1.3, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.5, 1.4, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 3.8, 1.7, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 3.8, 1.7, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.5, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.8, 1.5, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.7, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.4, 1.7, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.7, 1.5, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.7, 1.5, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.6, 1.0, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.6, 1.0, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.3, 1.7, 0.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.3, 1.7, 0.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.9, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.4, 1.9, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.0, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.0, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.6, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.4, 1.6, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 3.5, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 3.5, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 3.4, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 3.4, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.7, 3.2, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.1, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.1, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.5, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.4, 1.5, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 4.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 4.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 4.2, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 4.2, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.2, 1.2, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.2, 1.2, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 3.5, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 3.5, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.4, 3.0, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.4, 3.0, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.4, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.4, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.3, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.5, 1.3, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.5, 2.3, 1.3, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.5, 2.3, 1.3, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.4, 3.2, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.4, 3.2, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.6, 0.6 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.5, 1.6, 0.6 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.9, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.8, 1.9, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.0, 1.4, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.8, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.2, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.2, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.3, 3.7, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.3, 3.7, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.3, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.3, 1.4, 0.2 }, -1);
                    VF = false;
                }
                //versicolor
                if (cuatroentradas.Operaneurona(new double[4] { 7.0, 3.2, 4.7, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.0, 3.2, 4.7, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 4.5, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 3.2, 4.5, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 4.9, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.1, 4.9, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.3, 4.0, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.3, 4.0, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 2.8, 4.6, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 2.8, 4.6, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.5, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.8, 4.5, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 4.7, 1.6 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 3.3, 4.7, 1.6 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 2.4, 3.3, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 2.4, 3.3, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.6, 2.9, 4.6, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.6, 2.9, 4.6, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 2.7, 3.9, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 2.7, 3.9, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 2.0, 3.5, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 2.0, 3.5, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 4.2, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.9, 3.0, 4.2, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 4.0, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.2, 4.0, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.9, 4.7, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.9, 4.7, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.9, 3.6, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.9, 3.6, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.4, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.1, 4.4, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.5, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 3.0, 4.5, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 4.1, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 4.1, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 2.2, 4.5, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 2.2, 4.5, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.5, 3.9, 1.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.5, 3.9, 1.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.9, 3.2, 4.8, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.9, 3.2, 4.8, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.0, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.8, 4.0, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 4.9, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.5, 4.9, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.7, 1.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.8, 4.7, 1.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.9, 4.3, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.9, 4.3, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.6, 3.0, 4.4, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.6, 3.0, 4.4, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.8, 2.8, 4.8, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.8, 2.8, 4.8, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.0, 1.7 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.0, 5.0, 1.7 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.9, 4.5, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.9, 4.5, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.6, 3.5, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.6, 3.5, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.8, 1.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.4, 3.8, 1.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.7, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.4, 3.7, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 3.9, 1.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 3.9, 1.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.7, 5.1, 1.6 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.7, 5.1, 1.6 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.0, 4.5, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.0, 4.5, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 3.4, 4.5, 1.6 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 3.4, 4.5, 1.6 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.7, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.1, 4.7, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.3, 4.4, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.3, 4.4, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.1, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 3.0, 4.1, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.5, 4.0, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.5, 4.0, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.6, 4.4, 1.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.6, 4.4, 1.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.6, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 3.0, 4.6, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.6, 4.0, 1.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.6, 4.0, 1.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 2.3, 3.3, 1.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 2.3, 3.3, 1.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.7, 4.2, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.7, 4.2, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 3.0, 4.2, 1.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 3.0, 4.2, 1.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.9, 4.2, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.9, 4.2, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 2.9, 4.3, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 2.9, 4.3, 1.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 2.5, 3.0, 1.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 2.5, 3.0, 1.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.1, 1.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.8, 4.1, 1.3 }, 1);
                    VF = false;
                }
                #endregion

            }

        }
        #endregion

        #region SETOSA-VIRGINICA
        public void SETOSA_VIRGINICA()
        {
            int counter = 0;
            while (!VF)
            {
                VF = true;
                lBsalida.Items.Add("\n--Epoca--: "+ ++counter);
                lBsalida.Items.Add("W(0): "+cuatroentradas.Pesosiniciales[0]);
                lBsalida.Items.Add("W(1): "+cuatroentradas.Pesosiniciales[1]);
                lBsalida.Items.Add("W(2): "+cuatroentradas.Pesosiniciales[2]);
                lBsalida.Items.Add("W(3): "+cuatroentradas.Pesosiniciales[3]);
                lBsalida.Items.Add("Umbral θ: "+cuatroentradas.Umbralinicial);
                lBsalida.Items.Add(" \n ");

                #region SETOSA VIRGINICA
                //setosa
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.5, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.0, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.0, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.7, 3.2, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.1, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.1, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.6, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.6, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.7, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.9, 1.7, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.4, 1.4, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.4, 1.4, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.4, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.4, 2.9, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.4, 2.9, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.7, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.7, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.4, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.0, 1.4, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.3, 3.0, 1.1, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.3, 3.0, 1.1, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 4.0, 1.2, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 4.0, 1.2, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 4.4, 1.5, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 4.4, 1.5, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.9, 1.3, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.9, 1.3, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.5, 1.4, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.5, 1.4, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 3.8, 1.7, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 3.8, 1.7, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.5, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.8, 1.5, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.7, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.4, 1.7, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.7, 1.5, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.7, 1.5, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.6, 1.0, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.6, 1.0, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.3, 1.7, 0.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.3, 1.7, 0.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.4, 1.9, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.4, 1.9, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.0, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.0, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.4, 1.6, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.4, 1.6, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 3.5, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 3.5, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 3.4, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 3.4, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.7, 3.2, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.7, 3.2, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.1, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.1, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.4, 1.5, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.4, 1.5, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 4.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 4.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 4.2, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 4.2, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.2, 1.2, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.2, 1.2, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 3.5, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 3.5, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 3.1, 1.5, 0.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 3.1, 1.5, 0.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.4, 3.0, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.4, 3.0, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.4, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.4, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.3, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.5, 1.3, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.5, 2.3, 1.3, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.5, 2.3, 1.3, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.4, 3.2, 1.3, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.4, 3.2, 1.3, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.5, 1.6, 0.6 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.5, 1.6, 0.6 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.9, 0.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.8, 1.9, 0.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.8, 3.0, 1.4, 0.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.8, 3.0, 1.4, 0.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 3.8, 1.6, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 3.8, 1.6, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.6, 3.2, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.6, 3.2, 1.4, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.3, 3.7, 1.5, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.3, 3.7, 1.5, 0.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 3.3, 1.4, 0.2 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 3.3, 1.4, 0.2 }, -1);
                    VF = false;
                }
                //Virginica
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 6.0, 2.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 3.3, 6.0, 2.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 5.1, 1.9 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.1, 3.0, 5.9, 2.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.1, 3.0, 5.9, 2.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.9, 5.6, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.9, 5.6, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.8, 2.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 3.0, 5.8, 2.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.6, 3.0, 6.6, 2.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.6, 3.0, 6.6, 2.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 2.5, 4.5, 1.7 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 2.5, 4.5, 1.7 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.3, 2.9, 6.3, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.3, 2.9, 6.3, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 2.5, 5.8, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 2.5, 5.8, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.2, 3.6, 6.1, 2.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.2, 3.6, 6.1, 2.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 3.2, 5.1, 2.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 3.2, 5.1, 2.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.7, 5.3, 1.9 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.7, 5.3, 1.9 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.8, 3.0, 5.5, 2.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.8, 3.0, 5.5, 2.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.5, 5.0, 2.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.5, 5.0, 2.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.8, 5.1, 2.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.8, 5.1, 2.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 5.3, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 3.2, 5.3, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.5, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 3.0, 5.5, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 3.8, 6.7, 2.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 3.8, 6.7, 2.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 2.6, 6.9, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 2.6, 6.9, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 5.0, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.2, 5.0, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.2, 5.7, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.2, 5.7, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.8, 4.9, 2.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.8, 4.9, 2.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 2.8, 6.7, 2.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 2.8, 6.7, 2.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.7, 4.9, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.7, 4.9, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.3, 5.7, 2.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.2, 3.2, 6.0, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.2, 3.2, 6.0, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 2.8, 4.8, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 2.8, 4.8, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.9, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 3.0, 4.9, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.8, 5.6, 2.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.2, 3.0, 5.8, 1.6 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.2, 3.0, 5.8, 1.6 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.4, 2.8, 6.1, 1.9 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.4, 2.8, 6.1, 1.9 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.9, 3.8, 6.4, 2.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.9, 3.8, 6.4, 2.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.2 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.8, 5.6, 2.2 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.8, 5.1, 1.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.8, 5.1, 1.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.6, 5.6, 1.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.6, 5.6, 1.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 3.0, 6.1, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 3.0, 6.1, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 3.4, 5.6, 2.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 3.4, 5.6, 2.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 3.1, 5.5, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 3.1, 5.5, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 3.0, 4.8, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 3.0, 4.8, 1.8 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.4, 2.1 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.1, 5.4, 2.1 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 5.6, 2.4 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.1, 5.6, 2.4 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.1, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.1, 5.1, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 5.1, 1.9 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.8, 3.2, 5.9, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.8, 3.2, 5.9, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.5 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.3, 5.7, 2.5 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.2, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.0, 5.2, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 5.0, 1.9 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.5, 5.0, 1.9 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.2, 2.0 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 3.0, 5.2, 2.0 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 3.4, 5.4, 2.3 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 3.4, 5.4, 2.3 }, 1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 5.1, 1.8 }) !=1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.9, 3.0, 5.1, 1.8 }, 1);
                    VF = false;
                }
                #endregion
            }
        }
        #endregion

        #region VERSICOLOR VIRGINICA
        public void VERSICOLOR_VIRGINICA()
        {
            int counter = 0;
            while (!VF)
            {
                VF = true;
                lBsalida.Items.Add("\n--Epoca--: "+ ++counter);
                lBsalida.Items.Add("W(0): "+cuatroentradas.Pesosiniciales[0]);
                lBsalida.Items.Add("W(1): "+cuatroentradas.Pesosiniciales[1]);
                lBsalida.Items.Add("W(2): "+cuatroentradas.Pesosiniciales[2]);
                lBsalida.Items.Add("W(3): "+cuatroentradas.Pesosiniciales[3]);
                lBsalida.Items.Add("Umbral θ: "+cuatroentradas.Umbralinicial);
                lBsalida.Items.Add(" \n ");
                
                #region VERSICOLOR VIRGINICA 
                //versicolor

                if (cuatroentradas.Operaneurona(new double[4] { 7.0, 3.2, 4.7, 1.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.0, 3.2, 4.7, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 4.5, 1.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 3.2, 4.5, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 4.9, 1.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.1, 4.9, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.3, 4.0, 1.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.3, 4.0, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 2.8, 4.6, 1.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 2.8, 4.6, 1.5}, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.5, 1.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.8, 4.5, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 3.3, 4.7, 1.6 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 3.3, 4.7, 1.6 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9, 2.4, 3.3, 1.0 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9, 2.4, 3.3, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.6, 2.9, 4.6, 1.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.6, 2.9, 4.6, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.2, 2.7, 3.9, 1.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.2, 2.7, 3.9, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 2.0, 3.5, 1.0 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 2.0, 3.5, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 4.2, 1.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.9, 3.0, 4.2, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 4.0, 1.0 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.2, 4.0, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.9, 4.7, 1.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.9, 4.7, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.9, 3.6, 1.3 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.9, 3.6, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.4, 1.4 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.1, 4.4, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.5, 1.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 3.0, 4.5, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 4.1, 1.0 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 4.1, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 2.2, 4.5, 1.5 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 2.2, 4.5, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.5, 3.9, 1.1 }) !=-1)
                {
                    cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.5, 3.9, 1.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.9, 3.2, 4.8, 1.8 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.9, 3.2, 4.8, 1.8 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.0, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.8, 4.0, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 4.9, 1.5 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.5, 4.9, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.8, 4.7, 1.2 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.8, 4.7, 1.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.9, 4.3, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.9, 4.3, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.6, 3.0, 4.4, 1.4 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.6, 3.0, 4.4, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.8, 2.8, 4.8, 1.4 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.8, 2.8, 4.8, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.0, 1.7 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.0, 5.0, 1.7 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.9, 4.5, 1.5 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.9, 4.5, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.6, 3.5, 1.0 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.6, 3.5, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.8, 1.1 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.4, 3.8, 1.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.4, 3.7, 1.0 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.4, 3.7, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 3.9, 1.2 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 3.9, 1.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.7, 5.1, 1.6 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.7, 5.1, 1.6 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.4, 3.0, 4.5, 1.5 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.4, 3.0, 4.5, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 3.4, 4.5, 1.6 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 3.4, 4.5, 1.6 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 4.7, 1.5 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.1, 4.7, 1.5 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.3, 4.4, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.3, 4.4, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 3.0, 4.1, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 3.0, 4.1, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.5, 4.0, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.5, 4.0, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.5, 2.6, 4.4, 1.2 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.5, 2.6, 4.4, 1.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.6, 1.4 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 3.0, 4.6, 1.4 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.6, 4.0, 1.2 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.6, 4.0, 1.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.0, 2.3, 3.3, 1.0 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.0, 2.3, 3.3, 1.0 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.7, 4.2, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.7, 4.2, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 3.0, 4.2, 1.2 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 3.0, 4.2, 1.2 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.9, 4.2, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.9, 4.2, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 2.9, 4.3, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 2.9, 4.3, 1.3 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.1, 2.5, 3.0, 1.1 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.1, 2.5, 3.0, 1.1 }, -1);
                    VF = false;
                }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.8, 4.1, 1.3 }) !=-1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.8, 4.1, 1.3 }, -1);
                    VF = false;
                }

                //Virginica
                if (cuatroentradas.Operaneurona(new double[4] { 6.3,3.3,6.0,2.5 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3,3.3,6.0,2.5 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8,2.7,5.1,1.9 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8,2.7,5.1,1.9 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.1,3.0,5.9,2.1 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.1,3.0,5.9,2.1 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3,2.9,5.6,1.8 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3,2.9,5.6,1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5,3.0,5.8,2.2 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5,3.0,5.8,2.2 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.6,3.0,6.6,2.1 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.6,3.0,6.6,2.1 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 4.9,2.5,4.5,1.7 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 4.9,2.5,4.5,1.7 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.3,2.9,6.3,1.8 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.3,2.9,6.3,1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7,2.5,5.8,1.8 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 2.5, 5.8, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.2,3.6,6.1,2.5 }) !=1){cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.2, 3.6, 6.1, 2.5 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5,3.2,5.1,2.0 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5,3.2,5.1,2.0 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4,2.7,5.3,1.9 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.7, 5.3, 1.9 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.8, 3.0, 5.5, 2.1 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.8, 3.0, 5.5, 2.1 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 5.7, 2.5, 5.0, 2.0 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.7, 2.5, 5.0, 2.0 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.8, 5.1, 2.4 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.8, 5.1, 2.4 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 3.2, 5.3, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 3.2, 5.3, 2.3 },1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.5, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 3.0, 5.5, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 3.8, 6.7, 2.2 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 3.8, 6.7, 2.2 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 2.6, 6.9, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 2.6, 6.9, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 2.2, 5.0, 1.5 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 2.2, 5.0, 1.5 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.2, 5.7, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.2, 5.7, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 5.6, 2.8, 4.9, 2.0 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.6, 2.8, 4.9, 2.0 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 2.8, 6.7, 2.0 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 2.8, 6.7, 2.0 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.7, 4.9, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.7, 4.9, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.1 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.3, 5.7, 2.1 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.2, 3.2, 6.0, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.2, 3.2, 6.0, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 2.8, 4.8, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 2.8, 4.8, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 3.0, 4.9, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 3.0, 4.9, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.1 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.8, 5.6, 2.1 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.2, 3.0, 5.8, 1.6 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.2, 3.0, 5.8, 1.6 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.4, 2.8, 6.1, 1.9 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.4, 2.8, 6.1, 1.9 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.9, 3.8, 6.4, 2.0 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.9, 3.8, 6.4, 2.0 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 2.8, 5.6, 2.2 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 2.8, 5.6, 2.2 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.8, 5.1, 1.5 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.8, 5.1, 1.5 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.1, 2.6, 5.6, 1.4 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.1, 2.6, 5.6, 1.4 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 7.7, 3.0, 6.1, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 7.7, 3.0, 6.1, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 3.4, 5.6, 2.4 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 3.4, 5.6, 2.4 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.4, 3.1, 5.5, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.4, 3.1, 5.5, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.0, 3.0, 4.8, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.0, 3.0, 4.8, 1.8 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.4, 2.1 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.1, 5.4, 2.1 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.1, 5.6, 2.4 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.1, 5.6, 2.4 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.9, 3.1, 5.1, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.9, 3.1, 5.1, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 5.8, 2.7, 5.1, 1.9 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.8, 2.7, 5.1, 1.9 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.8, 3.2, 5.9, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.8, 3.2, 5.9, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.3, 5.7, 2.5 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.3, 5.7, 2.5 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.7, 3.0, 5.2, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.7, 3.0, 5.2, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.3, 2.5, 5.0, 1.9 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.3, 2.5, 5.0, 1.9 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.5, 3.0, 5.2, 2.0 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.5, 3.0, 5.2, 2.0 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 6.2, 3.4, 5.4, 2.3 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 6.2, 3.4, 5.4, 2.3 }, 1);
                         VF = false;
                     }
                if (cuatroentradas.Operaneurona(new double[4] { 5.9, 3.0, 5.1, 1.8 }) !=1)
                     {
                         cuatroentradas.OpNuevoAprendizaje(new double[4] { 5.9, 3.0, 5.1, 1.8 }, 1);
                         VF = false;
                     }
#endregion

                if (++counter==50)
                {
                  break;
                }
            }
            MessageBox.Show("No encontro solucion");
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            lBsalida.Items.Clear();
            tabla.Clear();
            Gridtabla.Columns.Clear();
            Application.Restart();//use esto para limpiar porque hay un problema con el listbox
                                  //no se si es mi version pero no permite volver a mostrar los 
                                  //datos nuevos una vez que se ha limpiado con el boton 
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tRivera Rivera Juan Carlos" +
                          "\n\tRocha Duran Yaneth");
        }
    }
}
