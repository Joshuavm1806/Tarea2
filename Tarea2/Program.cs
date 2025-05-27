using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Programa
    {
        static void Main()
        {
            string continuar = "s";

            int cantOperarios = 0;
            int cantTecnicos = 0;
            int cantProfesionales = 0;

            double acumOperarios = 0;
            double acumTecnicos = 0;
            double acumProfesionales = 0;

            while (continuar == "s" || continuar == "S")
            {
                string cedula;
                string nombre;
                int tipo;
                double horas;
                double precioHora;

                Console.Write("\nDigite la cédula: ");
                cedula = Console.ReadLine();

                Console.Write("Digite el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Digite el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
                tipo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite la cantidad de horas laboradas: ");
                horas = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite el precio por hora: ");
                precioHora = Convert.ToDouble(Console.ReadLine());

                double salarioOrdinario = horas * precioHora;
                double aumento = 0;
                string tipoTexto = "";

                if (tipo == 1)
                {
                    aumento = salarioOrdinario * 0.15;
                    tipoTexto = "Operario";
                }
                else if (tipo == 2)
                {
                    aumento = salarioOrdinario * 0.10;
                    tipoTexto = "Técnico";
                }
                else if (tipo == 3)
                {
                    aumento = salarioOrdinario * 0.05;
                    tipoTexto = "Profesional";
                }

                double salarioBruto = salarioOrdinario + aumento;
                double deduccion = salarioBruto * 0.0917;
                double salarioNeto = salarioBruto - deduccion;

                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Detalle:");
                Console.WriteLine("Cédula: " + cedula);
                Console.WriteLine("Nombre Empleado: " + nombre);
                Console.WriteLine("Tipo Empleado: " + tipoTexto);
                Console.WriteLine("Salario por Hora: " + precioHora);
                Console.WriteLine("Cantidad de Horas: " + horas);
                Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario Bruto: " + salarioBruto);
                Console.WriteLine("Deducción CCSS: " + deduccion);
                Console.WriteLine("Salario Neto: " + salarioNeto);
                Console.WriteLine("----------------------------\n");

                // Acumulados
                if (tipo == 1)
                {
                    cantOperarios++;
                    acumOperarios += salarioNeto;
                }
                else if (tipo == 2)
                {
                    cantTecnicos++;
                    acumTecnicos += salarioNeto;
                }
                else if (tipo == 3)
                {
                    cantProfesionales++;
                    acumProfesionales += salarioNeto;
                }

                Console.Write("¿Desea registrar otro empleado? (s/n): ");
                continuar = Console.ReadLine();
            }

            // Promedios
            double promOperarios = 0;
            double promTecnicos = 0;
            double promProfesionales = 0;

            if (cantOperarios > 0)
                promOperarios = acumOperarios / cantOperarios;

            if (cantTecnicos > 0)
                promTecnicos = acumTecnicos / cantTecnicos;

            if (cantProfesionales > 0)
                promProfesionales = acumProfesionales / cantProfesionales;

            Console.WriteLine("\nEstadísticas:");
            Console.WriteLine("1) Cantidad Empleados Tipo Operarios: " + cantOperarios);
            Console.WriteLine("2) Acumulado Salario Neto para Operarios: " + acumOperarios);
            Console.WriteLine("3) Promedio Salario Neto para Operarios: " + promOperarios);
            Console.WriteLine("4) Cantidad Empleados Tipo Técnico: " + cantTecnicos);
            Console.WriteLine("5) Acumulado Salario Neto para Técnicos: " + acumTecnicos);
            Console.WriteLine("6) Promedio Salario Neto para Técnicos: " + promTecnicos);
            Console.WriteLine("7) Cantidad Empleados Tipo Profesional: " + cantProfesionales);
            Console.WriteLine("8) Acumulado Salario Neto para Profesional: " + acumProfesionales);
            Console.WriteLine("9) Promedio Salario Neto para Profesionales: " + promProfesionales);
        }
    }
}
