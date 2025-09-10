using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class VistaReserva
    {
        ReservaService reservaService;

        public VistaReserva()
        {
            reservaService = new ReservaService();
        }

        public void MenuReserva()
        {
            int OP;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 4); Console.WriteLine("G E S T I O N  R E S E R V A S");
                Console.SetCursorPosition(20, 6); Console.WriteLine("1. Agregar Reserva");
                Console.SetCursorPosition(20, 8); Console.WriteLine("2. Consultar Reserva");
                Console.SetCursorPosition(20, 10); Console.WriteLine("0. Salir");

                Console.SetCursorPosition(20, 14); Console.WriteLine("Seleccione una opción: ");
                Console.SetCursorPosition(44, 14); OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        Capturar();
                        break;
                    case 2:
                        Consultar();
                        break;
                }

            } while (OP != 0);
        }

        private void Consultar()
        {
            int salto = 0;

            Console.Clear();
            Console.SetCursorPosition(16, 3); Console.WriteLine("L I S T A D O   D E   R E S E R V A S");
            Console.SetCursorPosition(15, 4); Console.Write("---------------------------------------------");
            Console.SetCursorPosition(15, 6); Console.WriteLine("ID");
            Console.SetCursorPosition(28, 6); Console.WriteLine("SOLICITANTE");
            Console.SetCursorPosition(47, 6); Console.WriteLine("SALA");
            Console.SetCursorPosition(55, 6); Console.WriteLine("FECHA");
            

            var lista = reservaService.ObtenerTodo();
            if (lista == null)
            {
                Console.Clear();
                Console.SetCursorPosition(15, 8 + salto); Console.Write("no hay datos que mostrar");
                Console.ReadKey();
                return;
            }
            foreach (var item in lista)
            {
                Console.SetCursorPosition(14, 8 + salto); Console.Write(item.Id);
                Console.SetCursorPosition(28, 8 + salto); Console.Write(item.Solicitante);
                Console.SetCursorPosition(48, 8 + salto); Console.Write(item.Sala);
                Console.SetCursorPosition(55, 8 + salto); Console.Write(item.Fecha);
                Console.SetCursorPosition(10, 9 + salto); Console.Write("----------------------------------------------------------------------");
                salto+=2;
            }
            Console.ReadKey();
        }


        private void Capturar()
        {
            Reserva reserva = new Reserva();
            Console.Clear();
            Console.SetCursorPosition(25, 3); Console.WriteLine("INFORMACION DEL PROPIETARIO");
            Console.SetCursorPosition(15, 4); Console.Write("---------------------------------------------");

            Console.SetCursorPosition(20, 6); Console.Write("Identificacion: ");
            reserva.Id = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(20, 8); Console.Write("Solicitante: ");
            reserva.Solicitante = (Console.ReadLine());

            Console.SetCursorPosition(20, 10); Console.Write("Sala: ");
            reserva.Sala = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(20, 12); Console.Write("Fecha: ");
            reserva.Fecha = (Console.ReadLine());


            var mensaje = reservaService.Agregar(reserva);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
















    }
}
