namespace spaceRandNum
{
    double generarNumero(int a, int b, int decimales)
    {

        double n;
        int aux;
        double pot;
        double fraction;

        if (a != b)
        {
            if (a > b)
            {
                aux = b;
                b = a;
                a = aux;
            }

            n = (double)random.Next(a,b);
            if ((decimales > 0) && (decimales < 10))
            {
                pot = Math.Pow(10,decimales);
                fraction = (random.Next(0,(int)pot) / (pot));
                n += fraction;
            }

            return n;
        }
        else
        {
            return a;
        }

    }

}