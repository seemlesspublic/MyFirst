using System;

namespace TABLO
{
    class Program
    {
        static void Main()
        {
            
            int HSTART, HEND, VSTART, VEND;


            Console.WriteLine("Введите первое значение в верхней части таблицы:");
            HSTART = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее значение в верхней части таблицы:");
            HEND = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первое значение в ЛЕВОЙ части таблицы:");
            VSTART = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите последнее значение в ЛЕВОЙ части таблицы:");
            VEND = int.Parse(Console.ReadLine());


            


            int var1h = HSTART;
            int var1v = VSTART;
            int var2h = HEND;
            int var2v = VEND;

            //************************************************************** разряд макс числа в  строке

            while (var1h <= var2h)


            {
                int var2hcount = 0;
                int sph2 = var2h;


                while (sph2 > 0)

                {
                    var2hcount++;
                    sph2 /= 10;
                }
                //************************************************************** конец разряд макс числа в  строке

                int spaces = var2v;
                int spaces_count = 0;

                while (spaces > 0)
                {
                    spaces_count++;
                    spaces /= 10;
                    Console.Write(" ");
                }

                Console.Write("|");


                ////************************************************************** расчёт разрядности макс числа данных

                //int maxdata = var2h * var2v;
                //int maxdatacount = 0;

                ////************************************************************** вывод разрядности макс числа данных
                ///
                //******************************************************************* расчет maxdatacount

                int maxdata = var2h * var2v;
                int maxdatacount = 0;

                while (maxdata > 0)
                {
                    maxdatacount++;
                    maxdata /= 10;

                }

                //******************************************************************* конец подсчет maxdatacount

                while (maxdata > 0)
                {
                    maxdatacount++;
                    maxdata /= 10;
                    
                }
                while (var1h <= var2h)                      // начало вывода строки

                {
                    int var1hcount = 0;                     //разряд мин числа строки
                    int sph1 = var1h;

                    while (sph1 > 0)

                    {
                        var1hcount++;
                        sph1 /= 10;
                    }

                    int Vvarhcount = maxdatacount - var1hcount;  //  - var1hcount  - var2hcount   разряд макс - мин строки

                    while (Vvarhcount >= 0)
                    {
                        Vvarhcount--;
                        Console.Write(" "); //*
                    }


                    {
                        Console.Write(var1h);        // вывод строки
                    }

                    var1h++;

                }
                Console.WriteLine();                        // конец вывода строки


                //******************************************************************* начало вывода строки подчерка

                int Vspaces = var2v;
                int Vspaces_count = 0;


                while (Vspaces > 0)

                {
                    Vspaces_count++;
                    Vspaces /= 10;
                    Console.Write("-");
                }


                Console.Write("+");                          //  вывод "+"  в строке подчерка

                //******************************************************************* продолжение вывода строки подчерка

                int Hmaxnumber = HEND;
                int Hmaxnumber_count = 0;

                while (Hmaxnumber > 0)                      //подсчет коллич введеных цыфр разрядности макс числа
                {
                    Hmaxnumber_count++;
                    Hmaxnumber /= 10;
                }
                //******************************************************************* подсчет коллич введеных цифр
                var1h = HSTART;
                var2h = HEND;

                int Hnumber = (var2h - var1h) + 1;              

                int Hspace_count = Hnumber * (maxdatacount + 1);
                
                while (Hspace_count > 0)
                {
                    Console.Write("-");
                    Hspace_count--;
                }

                Console.WriteLine();

                //******************************************************************* конец вывода строки подчерка



                //******************************************************************* расчет пробелов разряда макс колонки

                int var2vcount = 0;
                int spv2 = var2v;


                while (spv2 > 0)

                {
                    var2vcount++;
                    spv2 /= 10;
                }
                //******************************************************************* конец пробелов разряда макс колонки

                

                //******************************************************************* начало вывода колонки


                var1v = VSTART;
                var2v = VEND;

                while (var1v <= var2v)

                {
                    int var1vcount = 0;
                    int spv1 = var1v;

                    while (spv1 > 0)

                    {
                        var1vcount++;
                        spv1 /= 10;
                    }

                    int Vvarvcount = var2vcount - var1vcount;  //подсчет разряд (макс - мин) колонки

                    while (Vvarvcount > 0)                      // вывод пробелов разряд колонки
                    {
                        Vvarvcount--;
                        Console.Write(" "); //*
                    }

                    Console.Write(var1v + "|");        // вывод значений колонки



                    //**********************************// начало вывода строки

                    var1h = HSTART;
                    var2h = HEND;

                    while (var1h <= var2h)

                    {
                        int result = var1v * var1h;



                        int resultcount = 0;                     //разряд мин числа строки
                        int resultsph1 = result;

                        while (resultsph1 > 0)

                        {
                            resultcount++;
                            resultsph1 /= 10;
                        }

                        int Vresultcountcount = (maxdatacount + 1) - resultcount;  //разряд макс - мин строки

                        while (Vresultcountcount > 0)
                        {
                            Vresultcountcount--;
                            Console.Write(" "); //*
                        }
                        {
                            Console.Write(result);
                        }

                        var1h++;
                    }
                    Console.WriteLine();
                    var1v++;
                }
            }
        }
    }
}