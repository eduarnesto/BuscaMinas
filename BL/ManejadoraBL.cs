using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraBL
    {
        public ClsTablero GetTablero(int dificultad)
        {
            ClsTablero tablero;
            switch (dificultad)
            {
                case 1:
                    tablero = new ClsTablero(2,1);
                    break;
                case 2:
                    tablero = new ClsTablero(3, 4);
                    break;
                case 3:
                    tablero = new ClsTablero(4, 7);
                    break;
                default:
                    tablero = new ClsTablero(5, 15);
                    break;
            }
            return tablero;
        }

        public int GeTNumeroVidas(int dificultad)
        {
            int vidas;
            switch (dificultad)
            {
                case 1:
                    vidas = 5;
                    break;
                case 2:
                    vidas = 4;
                    break;
                default:
                    vidas = 3;
                    break;
            }
            return vidas;
        }
    }
}
