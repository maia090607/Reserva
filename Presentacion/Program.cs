using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Program
    {
        ReservaService reservaService;

        public Program()
        {
            reservaService = new ReservaService();
        }

        public void MenuPrincipal()
        {
            int OP;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 6); Console.Write("1. Gestionar Reserva ...");
                Console.SetCursorPosition(20, 8); Console.Write("0. Salir");
                Console.SetCursorPosition(17, 4); Console.Write("M E N U   P R I N C I P A L");

                Console.SetCursorPosition(20, 10); Console.Write("Seleccione una opción: ");

                Console.SetCursorPosition(44, 10); OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case 1:
                        VistaReserva vistaReserva = new VistaReserva();
                        vistaReserva.MenuReserva();
                        break;
                    default:
                        break;
                }
            } while (OP != 0);
        }

    }
}
