using System;
using System.Collections.Generic;
using System.Text;

namespace AppPiker.Control
{
    public class CalculosMatematicos
    {
        public CalculosMatematicos() { }

        public Boolean NumeroPar(int valor)
        {
            if (valor % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public int CalcularFatorial(int valor)
        {
            int n = valor;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = valor - 1; i > 0; i--)
                {
                    n *= i;
                }
            }
            return n;
        }

        public bool NumeroPrimo(int valor)
        {
            bool primo = false;
            int count = 0;
            for (int i = valor; i > 0; i--)
            {
                if (valor % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                primo = true;
            }
            return primo;
        }
    }
}
