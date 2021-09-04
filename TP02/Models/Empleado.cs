using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP02.Models
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double salario;
        private string direccion;
        private string rol;
        private DateTime fechadeingreso;
        private double antiguedad;
        private DateTime fechadenacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public double Salario { get => salario; set => salario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Rol { get => rol; set => rol = value; }
        public DateTime Fechadeingreso { get => fechadeingreso; set => fechadeingreso = value; }
        public double Antiguedad { get => antiguedad; set => antiguedad = value; }
        public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }

        public double Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = DateTime.Today.AddTicks(-Fechadenacimiento.Ticks).Year - 1;
            }
        }

       

        public Empleado(string nombre, string apellido, int edad, DateTime fechaingreso, DateTime fechanac, string rol, string direccion)
        {
            Random aleatorio = new Random();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Fechadenacimiento = fechanac;
            this.Rol = rol;
            this.Fechadeingreso = fechaingreso;
            this.Direccion = direccion;
            this.Antiguedad = DateTime.Today.AddTicks(-Fechadeingreso.Ticks).Year - 1;
            this.Salario = CalcularSalario(this.Antiguedad);
  
           
        }

        private double CalcularSalario(double antiguedad)
        {
            int SueldoBasico = 15000;
            return SueldoBasico + (SueldoBasico * 0.1) * antiguedad - SueldoBasico * 0.15;
        }
    }
}
