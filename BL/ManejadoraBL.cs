using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraBL
    {
        // Retorna el número de bombas según el nivel de dificultad
        public static int GetNumeroBombas(int dificultad)
        {
            int numBombas;
            switch (dificultad)
            {
                case 1:
                    numBombas = 1;
                    break;
                case 2:
                    numBombas = 2;
                    break;
                case 3:
                    numBombas = 4;
                    break;
                case 4:
                    numBombas = 6;
                    break;
                case 5:
                    numBombas = 10;
                    break;
                case 6:
                    numBombas = 14;
                    break;
                case 7:
                    numBombas = 20;
                    break;
                default:
                    numBombas = 25;
                    break;
            }
            return numBombas;
        }

        // Retorna el número de casillas a revelar según el nivel de dificultad
        public static int GetCasillasARevelar(int dificultad)
        {
            int casillasARevelar;
            switch (dificultad)
            {
                case 1:
                    casillasARevelar = 3;
                    break;
                case 2:
                    casillasARevelar = 5;
                    break;
                case 3:
                    casillasARevelar = 8;
                    break;
                case 4:
                    casillasARevelar = 12;
                    break;
                case 5:
                    casillasARevelar = 15;
                    break;
                case 6:
                    casillasARevelar = 20;
                    break;
                case 7:
                    casillasARevelar = 25;
                    break;
                default:
                    casillasARevelar = 30;
                    break;
            }
            return casillasARevelar;
        }

        // Retorna el tamaño del lado del tablero según el nivel de dificultad
        public static int GetLadoTablero(int dificultad)
        {
            int lado;
            switch (dificultad)
            {
                case 1:
                    lado = 3;
                    break;
                case 2:
                    lado = 4;
                    break;
                case 3:
                    lado = 5;
                    break;
                case 4:
                    lado = 6;
                    break;
                case 5:
                    lado = 7;
                    break;
                case 6:
                    lado = 8;
                    break;
                case 7:
                    lado = 9;
                    break;
                default:
                    lado = 10;
                    break;
            }
            return lado;
        }

        // Retorna el número de vidas según el nivel de dificultad
        public static int GetNumeroVidas(int dificultad)
        {
            int vidas;
            switch (dificultad)
            {
                case 1:
                    vidas = 3;
                    break;
                case 2:
                    vidas = 3;
                    break;
                case 3:
                    vidas = 3;
                    break;
                case 4:
                    vidas = 3;
                    break;
                case 5:
                    vidas = 2;
                    break;
                case 6:
                    vidas = 2;
                    break;
                case 7:
                    vidas = 1;
                    break;
                default:
                    vidas = 1;
                    break;
            }
            return vidas;
        }

    }
}
