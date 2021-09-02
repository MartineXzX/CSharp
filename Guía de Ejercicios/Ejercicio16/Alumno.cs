using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        private static Random rng;

        static Alumno()
        {
            Alumno.rng = new Random();
        }
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = rng.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            //DATOS DEL ALUMNO
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Nota Uno: " + this.nota1);
            sb.AppendLine("Nota Dos: " + this.nota2);

            if (notaFinal != -1)
            {
                sb.AppendLine("Nota Final: "+ this.notaFinal);
            }
            else
            {
                sb.AppendLine("Nota Final: Alumno Desaprobado");
            }
            
            sb.AppendLine("--------------------------------");
            return sb.ToString();
        }
    }
}
