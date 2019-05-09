using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            int U, L, M, N, R, T, Y, X, S, J;

            Console.WriteLine("Por favor espere...");

            for (U = 1; U < 10; U++)
            {
                for (L = 0; L < 10; L++)
                {
                    for (M = 0; M < 10; M++)
                    {
                        for (N = 0; N < 10; N++)
                        {
                            for (R = 0; R < 10; R++)
                            {
                                for (T = 0; T < 10; T++)
                                    {
                                    for (Y = 1; Y < 10; Y++)
                                    {
                                        for (X = 1; X < 10; X++)
                                        {
                                            for (S = 0; S < 10; S++)
                                            {
                                                for (J = 0; J < 10; J++)
                                                {
                                                    //Console.WriteLine("Testeando: U= " + U + ",L= " + L + ",M= " + M + ",N= " + N + ",R= " + R + ",T= " + T + ",Y= " + Y + ",X= " + X + ",S= " + S + ",J= " + J);
                                                    if (((100 * U * L) + (10 * U * M) + (U * N)) == ((1000 * R) + (100 * T) + (10 * Y) + X))
                                                    {
                                                        if ((((100 * S) + (10 * T) + (U)) - ((100 * T) + (10 * Y) + X) == ((100 * T) + (10 * Y) + Y)))
                                                        {
                                                            if (((100 * X * L) + (10 * X * M) + (X * N)) == ((1000 * T) + (100 * Y) + (10 * Y) + J))
                                                            {
                                                                if ((N - J) == Y)
                                                                {
                                                                    //Divisor * Cociente + Residuo = Dividendo
                                                                    if (((L * 100 + M * 10 + N)* (U * 10 + X)+Y) == (R * 10000 + S * 1000 + T * 100 + U * 10 + N))
                                                                    {
                                                                        Console.WriteLine("Resultados encontrados: \n\nU= " + U + "\nL= " + L + "\nM= " + M + "\nN= " + N + "\nR= " + R + "\nT= " + T + "\nY= " + Y + "\nX= " + X + "\nS= " + S + "\nJ= " + J);
                                                                        Console.ReadKey();
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            /*int T, E, H, A, W;
            for(T=0;T<10;T++)
            {
                for(E=0; E<10; E++)
                {
                    for(H=0; H<10; H++)
                    {
                        for(A=0;A<10;A++)
                        {
                            for(W=0;W<10;W++)
                            {
                                if((T * 1000 + E * 100 + H * 10 + E)+(A*10000+H*1000+A*100+H*10+A)==(T*10000+E*1000+H*100+A*10+W) && (T * 10000 + E * 1000 + H * 100 + A * 10 + W) != 0)
                                {
                                    Console.WriteLine("Resultados encontrados: \n\nT= " + T + "\nE= " + E + "\nH= " + H + "\nA= " + A + "\nW= " + W);
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                }
            }*/
        }
    }
}
