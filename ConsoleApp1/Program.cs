using  System;
class printdata
    {
        void print(int i)
        {
        Console.WriteLine("printing int:{0}", i);
        }
    void print(double f)
    {
        Console.WriteLine("printing int:{0}", f);

    }
    void print(string s)
    {
        Console.WriteLine("printing int:{0}", s);
    }
    static void Main(string[] args)
    {
        printdata printdata = new printdata();
        printdata.print(5);
        printdata.print(500.263);
        printdata.print("Hello C++");
            Console.ReadKey();
    }
    }
