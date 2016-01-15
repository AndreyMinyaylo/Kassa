using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int i, j, h, u, t, s, ss, ll;

            string p = " ";
            string o = "-";
            string rrr = Convert.ToString(y2);
            ll = rrr.Length + 1;
            do
            {
                Console.Write(p);
                ll--;
            }
            while (ll > 0);
            Console.Write("|");
                for (i = x1; i <= x2; i++)
                {
                  string k = Convert.ToString(i);
                    s = k.Length;
                    h = x2 * y2;
                string l = Convert.ToString(h);
                u = l.Length;
                    if (u == s )
                    {
                        u = 1;
                    }
                    else if (s < u)
                    {
                        u = (u - s) + 1;
                    }
                     do
                    {
                    Console.Write(p);
                    u--;
                    }
                while (u > 0);
                    Console.Write(i);
                    }
            Console.Write("\n");
            string rr = Convert.ToString(y2);
            ll = rr.Length+1;
            do
            {
                Console.Write(o);
                ll--;
            }
            while (ll > 0);
            Console.Write("+");
            for (i = x1; i <= x2; i++)
            {
                h = x2 * y2;
                string l = Convert.ToString(h);
                u = l.Length + 1;

                do
                {
                    Console.Write(o);
                    u--;
                }
                while (u > 0);
            }
            Console.Write("\n");
            for (i = y1; i <= y2; i++)
            {
                string c = Convert.ToString(i);
                ss = c.Length;
                string r = Convert.ToString(y2);
                ll = r.Length;
                if (ss == ll)
                {
                    ll = 1;
                }
                else if (ss < ll)
                {
                    ll = (ll - ss) + 1;
                }
                do
                {
                    Console.Write(p);
                    ll--;
                }
                while (ll > 0);
                Console.Write(i+"|");
                for (j = x1; j <= x2; j++)
                {
                    t = i * j;
                    string k = Convert.ToString(t);
                    s = k.Length;
                    h = x2 * y2;
                    string l = Convert.ToString(h);
                    u = l.Length;
                   if (s == u)
                    {
                        u =  1;
                    }
                    else if(s < u)
                    {
                        u = (u - s)+1;
                    }
                    
                        do
                    {
                            Console.Write(p);
                            u--;
                    }
                    while (u > 0);
                        Console.Write(t);

                    if (j == x2)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}