using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac4Perceptron
{
    public class operaciones
    {
        public double[] Pesosiniciales;
        double[] PesosAnteriores;
        public double Umbralinicial;
        double UmbralAnterior;
        public double errorAprendizaje;

        public operaciones(int numentradas, double porcentajeerror)//Funcion de los parametros de entrada de los datos y los parametros de realimentacion 
        {
            errorAprendizaje = porcentajeerror; 
            Pesosiniciales = new double[numentradas];
            PesosAnteriores = new double[numentradas];
            OperaAprendizaje();
        }
        public double Operaneurona(double[] entradas)//Funcion de salida y comparacion de los resoltados booleanos
        {
            double sum = 0;
            for (int k = 0; k<Pesosiniciales.Length; k++)
            {
                sum += Math.Round(entradas[k]*Pesosiniciales[k], 3);
            }
            sum += Math.Round(Umbralinicial, 3);

            //Se determina si la salida esta bien clasificada
            double salida = sum;
            return salida > -1 ? 1 : -1;//Si salida es mayor que -1 es 1 (true) si es menor entonces es -1 (false) 
        }
        public void OperaAprendizaje() //Funcion que hace la valoracion de una primer evaluacion utilizando un rango variable en los pesos
        {
            Random rango = new Random();
            for (int i = 0; i < PesosAnteriores.Length; i++)
            {
                PesosAnteriores[i] = Math.Round(Convert.ToSingle(rango.NextDouble() - rango.NextDouble()),3);
            }
            UmbralAnterior = Math.Round(Convert.ToSingle(rango.NextDouble() - rango.NextDouble()),3);

            Pesosiniciales = PesosAnteriores; //Se igualan los resultados para pasar estos parametros a otra funcion
            Umbralinicial = UmbralAnterior;//Igualmente se igualan resultados para recalcular en otra funcion
        }
        public void OpNuevoAprendizaje(double[] entradas, double OpEsperada) //Funcion de realimentaxion para mejorar el porcentaje de error
        {
            //Se detecta el error de clasificacion
            double error = OpEsperada - Operaneurona(entradas);
            for (int j= 0;  j< Pesosiniciales.Length; j++)
            {
                //Se suman el peso dado y el error, se multiplican por las entradas y el error detectado
               Pesosiniciales[j] = Math.Round(PesosAnteriores[j] + errorAprendizaje * error * entradas[j],3);
            }

            //Se declaran el nombre de los nuevos valores 
            Umbralinicial = Math.Round(UmbralAnterior + errorAprendizaje*error,3); 
            PesosAnteriores = Pesosiniciales;//aqui se regresa a la variable inicial una vez ya calculada sin tanto error
            UmbralAnterior = Umbralinicial;
        }
        
    }
}
