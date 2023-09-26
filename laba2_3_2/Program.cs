namespace laba2_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть чисельник та знаменник 1го дробу через Enter");
            MyFrac f1 = new MyFrac(long.Parse(Console.ReadLine()), long.Parse(Console.ReadLine()));
            Console.WriteLine("Введiть чисельник та знаменник 2го дробу через Enter");
            MyFrac f2 = new MyFrac(long.Parse(Console.ReadLine()), long.Parse(Console.ReadLine()));

            Console.WriteLine("Сума 2х дробiв у рядковому поданнi:");
            MyFrac fs = MyFrac.Plus(f1, f2);
            Console.WriteLine(fs.ToString());
            Console.WriteLine("Сума 2х дробiв у рядковому поданнi з цiлою частиною:");
            Console.WriteLine(fs.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення отриманого дробу:");
            Console.WriteLine(fs.DoubleValue());

            Console.WriteLine("Рiзниця 2х дробiв у рядковому поданнi:");
            MyFrac fs1 = MyFrac.Minus(f1, f2);
            Console.WriteLine(fs1.ToString());
            Console.WriteLine("Рiзниця 2х дробiв у рядковому поданнi з цiлою частиною:");
            Console.WriteLine(fs1.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення отриманого дробу:");
            Console.WriteLine(fs1.DoubleValue());

            Console.WriteLine("Добуток 2х дробiв у рядковому поданнi:");
            MyFrac fm = MyFrac.Multiply(f1, f2);
            Console.WriteLine(fm.ToString());
            Console.WriteLine("Добуток 2х дробiв у рядковому поданнi з цiлою частиною:");
            Console.WriteLine(fm.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення отриманого дробу:");
            Console.WriteLine(fm.DoubleValue());

            Console.WriteLine("Частка 2х дробiв у рядковому поданнi:");
            MyFrac fd = MyFrac.Divide(f1, f2);
            Console.WriteLine(fd.ToString());
            Console.WriteLine("Частка 2х дробiв у рядковому поданнi з цiлою частиною:");
            Console.WriteLine(fd.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення отриманого дробу:");
            Console.WriteLine(fd.DoubleValue());

            Console.WriteLine("Введiть число n, щоб порахувати суму вигляду 1/(1*2)+1/(2*3)+1/(3*4)+...+1/(n*(n+1)):");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Сума у рядковому поданнi:");
            MyFrac fsum1 = MyFrac.CalcSum1(n1);
            Console.WriteLine(fsum1.ToString());
            Console.WriteLine("Сума у рядковому поданнi з цiлою частиною:");
            Console.WriteLine(fsum1.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення отриманого дробу:");
            Console.WriteLine(fsum1.DoubleValue());

            Console.WriteLine("Введiть число n, щоб порахувати добуток вигляду (1–1/4)*(1–1/9)*(1–1/16)*...*(1–1/n^2):");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Добуток у рядковому поданнi:");
            MyFrac fsum2 = MyFrac.CalcSum2(n2);
            Console.WriteLine(fsum2.ToString());
            Console.WriteLine("Добуток у рядковому поданнi з цiлою частиною:");
            Console.WriteLine(fsum2.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення отриманого дробу:");
            Console.WriteLine(fsum2.DoubleValue());
        }
    }
}