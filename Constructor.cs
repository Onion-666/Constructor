using System;
using System.Globalization;
using System.Runtime.InteropServices;

class MyClass
{
    public int num;
    public char symb;
    public string txt;
    public void Show()
    {
        Console.WriteLine("Поля: {0}, \'{1}\' и \'{2}\'", num, symb, txt);
    }
    public MyClass()
    {
        num = 100;
        symb = 'A';
        txt = "Красный";
    }
    public MyClass(int n)
    {
        num = n;
        symb = 'B';
        txt = "Желтый";
    }
    public MyClass(int n, char s)
    {
        num = n;
        symb = s;
        txt = "Зеленый";
    }
    public MyClass(int n, char s, string t)
    {
        num = n;
        symb = s;
        txt = t;
    }
    public MyClass(string t)
    {
        num = 0;
        symb = 'Z';
        txt = t;
    }
}
class Programm
{
    static void Main()
    {
        MyClass A = new MyClass();
        A.Show();
        MyClass B = new MyClass(200);
        B.Show();
        MyClass C = new MyClass(300, 'C');
        C.Show();
        MyClass D = new MyClass(400, 'D', "Синий");
        D.Show();
        MyClass F = new MyClass('A');
        F.Show();
        MyClass G = new MyClass("Серый");
        G.Show();
        MyClass2 A1 = new MyClass2();
    }
}
//Если в классе убрать версию конструктора без аргументов, то конструктор по умолчанию пропадет
/*
    public MyClass()
    {
        num = 100;
        symb = 'A';
        txt = "Красный";
    }
*/
class MyClass2
{
    public int n;
    public void Show()
    {
        Console.WriteLine(n);
    }
    public MyClass2(int z)
    {
        n = z;
    }
}
