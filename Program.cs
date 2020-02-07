using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackOyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] yerler = new int[25, 50];
            oyuntahtasi cagir = new oyuntahtasi();
            oyun oyun = new oyun();
            int hamlesayac = 0, x = 0, y = 0, renk = 3,engelsayisi=0;
            Stack xekseni = new Stack();
            Stack yekseni = new Stack();
            xekseni.Push(0);
            yekseni.Push(0);
            Console.WriteLine("Kaç Adet Engel Olsun?");
            engelsayisi = Convert.ToInt32(Console.ReadLine());
            oyun.doldur(engelsayisi,ref yerler);

            while (!(yerler[24, 49] == 5))
            {
               
                Console.Clear();
                cagir.tahta(hamlesayac, yerler, x, y);
                
                oyun.zarat(out renk);
                cagir.zar(renk, hamlesayac, yerler, x, y);
              //  System.Threading.Thread.Sleep(300);
                
                Console.ReadLine();

                if (renk == 2)
                {
                    if (!(x + 2 >= 25)||(y==49&&x+2==25))
                    {
                        if (y == 49 && x + 2 == 25)
                        {
                            x = x + 1;
                            y = y + 0;
                            yerler[x, y] = 5;
                            yerler[x - 1, y] = 1;

                        }
                        else
                        {
                            x = x + 1;
                            y = y + 0;
                            if (!(yerler[x, y] == 9))
                            {
                                x = x + 1;
                                y = y + 0;
                                if (yerler[x, y] == 9)
                                {
                                    x = x - 2;
                                    y = y - 0;
                                    yerler[x, y] = 1;
                                    x = Convert.ToInt32(xekseni.Pop());
                                    y = Convert.ToInt32(yekseni.Pop());
                                   
                                    x = Convert.ToInt32(xekseni.Pop());
                                    y = Convert.ToInt32(yekseni.Pop());
                                    //Engele çarptığında çarpmadan önceki konumuna dönmesini isterseni x y leri 1er tane yazınız.
                                    yerler[x, y] = 5;
                                    xekseni.Push(x);
                                    yekseni.Push(y);

                                }
                                else
                                {

                                    xekseni.Push(x);
                                    yekseni.Push(y);
                                    x = Convert.ToInt32(xekseni.Peek());
                                    y = Convert.ToInt32(yekseni.Peek());
                                    yerler[x, y] = 5;
                                    yerler[x - 2, y] = 1;
                                }
                            }
                            else
                            {
                                x = x - 1;
                                y = y - 0;
                                yerler[x, y] = 1;
                                x = Convert.ToInt32(xekseni.Pop());
                                x = Convert.ToInt32(xekseni.Pop());
                                
                                y = Convert.ToInt32(yekseni.Pop());
                                y = Convert.ToInt32(yekseni.Pop());
                                //Engele çarptığında çarpmadan önceki konumuna dönmesini isterseni x y leri 1er tane yazınız.
                                yerler[x, y] = 5;
                                xekseni.Push(x);
                                yekseni.Push(y);
                            }
                        }
                    }
                }


                if (renk == 1)
                {
                    if (!(y + 2 >= 50) || (x == 24 && y + 2 == 50))
                    {
                        if (x == 24 && y + 2 == 50)
                        {
                            x = x + 0;
                            y = y + 1;
                            yerler[x, y] = 5;
                            yerler[x, y - 1] = 1;
                        }
                        else
                        {
                            x = x + 0;
                            y = y + 1;
                            if (!(yerler[x, y] == 9))
                            {
                                x = x + 0;
                                y = y + 1;
                                if (yerler[x, y] == 9)
                                {
                                    x = x - 0;
                                    y = y - 2;
                                    yerler[x, y] = 1;
                                    x = Convert.ToInt32(xekseni.Pop());
                                    y = Convert.ToInt32(yekseni.Pop());
                                    
                                    x = Convert.ToInt32(xekseni.Pop());
                                    y = Convert.ToInt32(yekseni.Pop());

                                    yerler[x, y] = 5;
                                    xekseni.Push(x);
                                    yekseni.Push(y);
                                }
                                else
                                {

                                    xekseni.Push(x);
                                    yekseni.Push(y);
                                    x = Convert.ToInt32(xekseni.Peek());
                                    y = Convert.ToInt32(yekseni.Peek());
                                    yerler[x, y] = 5;
                                    yerler[x, y - 2] = 1;
                                }
                            }
                            else
                            {
                                x = x - 0;
                                y = y - 1;
                                yerler[x, y] = 1;
                                x = Convert.ToInt32(xekseni.Pop());
                                y = Convert.ToInt32(yekseni.Pop());
                                
                                
                                x = Convert.ToInt32(xekseni.Pop());
                                y = Convert.ToInt32(yekseni.Pop());
                                yerler[x, y] = 5;
                                xekseni.Push(x);
                                yekseni.Push(y);
                            }

                        }
                    }

                }

                if (renk == 3)
                {
                    if (!(y + 1 >= 50) && !(x + 1 >= 25))
                    {

                        x = x + 0;
                        y = y + 1;
                        if (!(yerler[x, y] == 9))
                        { 
                            x = x + 1;
                            y = y + 0;
                            if (yerler[x, y] == 9)
                            {
                                x = x - 1;
                                y = y - 1;
                                yerler[x, y] = 1;
                                x = Convert.ToInt32(xekseni.Pop());
                                y = Convert.ToInt32(yekseni.Pop());
                                
                                x = Convert.ToInt32(xekseni.Pop());
                                y = Convert.ToInt32(yekseni.Pop());
                                yerler[x, y] = 5;
                                xekseni.Push(x);
                                yekseni.Push(y);

                            }
                            else
                            {

                                xekseni.Push(x);
                                yekseni.Push(y);
                                x = Convert.ToInt32(xekseni.Peek());
                                y = Convert.ToInt32(yekseni.Peek());
                                yerler[x, y] = 5;
                                yerler[x - 1, y - 1] = 1;
                            }
                    }
                    else
                    {
                            x = x - 0;
                            y = y - 1;
                            yerler[x, y] = 1;
                            x = Convert.ToInt32(xekseni.Pop());
                            y = Convert.ToInt32(yekseni.Pop());
                            
                            x = Convert.ToInt32(xekseni.Pop());
                            y = Convert.ToInt32(yekseni.Pop());
                            yerler[x, y] = 5;
                            xekseni.Push(x);
                            yekseni.Push(y);
                        }

                    }
                }

                hamlesayac++;
                

            }
            Console.Clear();
            Console.WriteLine("Tebrikler oyunu bitirdiniz. Hamle sayınız:" + hamlesayac);
            Console.ReadLine();


                }
            }
        }
