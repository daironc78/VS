using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsCMD
{
    public class Metodos
    {
        // CONTAR SALTOS HASTA ENCONTRAR EL VALOR FINAL
        public int ContarSaltos(int[] A)
        {
            int salto = 0;
            int value = 0;
            if (A.Length != 0)
            {
                for (int i = 0; i <= A.Length; i++)
                {
                    salto = i + 1;
                    value = A[value];
                    if (value == -1) break;
                }
            }
            return salto;
        }

        // VALIDAR EL NUMERO ENTERO NATURAL INEXISTENTE EN EL ARREGLO
        public int DistintoNumero(int[] A)
        {
            int value = 1;
            bool validacion = true;
            if (A.Length != 0)
            {
                for (value = 1; value <= A.Max(); value++)
                {
                    if (validacion)
                    {
                        for (int x = 0; x < A.Length; x++)
                        {
                            if (A[x] == value)
                            {
                                validacion = true;
                                break;
                            }
                            else validacion = false;
                        }
                    }
                    else
                    {
                        value--;
                        break;
                    }
                }
                if (validacion) value = A.Max() + 1;
            }

            return value;
        }

        // DIVISORES POR 2, 3, o 5.
        public void Divisores(int  num)
        {
            string text = string.Empty;
            for (int i = 1; i < num; i++)
            {
                if ((i % 2) == 0) text = "Codility";
                if ((i % 3) == 0) text = text + "Test";
                if ((i % 5) == 0) text = text + "Coders";

                if (text == string.Empty) Console.WriteLine(i);
                else Console.WriteLine(text);

                text = string.Empty;
            }
        }
    }
}
