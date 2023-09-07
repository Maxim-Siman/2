using System.ComponentModel.Design;

class Myarr
{
    public int x, y, z;
    public bool Boolx, Booly, Boolz;

    public Myarr(int x = 0, int y = 0, int z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }


    public static bool operator true(Myarr obj1)
    {
        if ((obj1.x % 2 == 0) || (obj1.y % 2 == 0) || (obj1.z % 2 == 0))
            return true; 
        return false;
        
    }

    public static bool operator false(Myarr obj1)
    {
        if ((obj1.x % 2 == 1) || (obj1.y % 2 == 1) || (obj1.z % 2 == 1))
            return true; 
        return false;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Myarr point = new Myarr(1, 3, 2);
        Myarr point2 = new Myarr(3, 3, 1);
        if (point)
        {
            Console.WriteLine("Все цифры подходят по условию");
        }
        else
        {
            Console.WriteLine("Не все числа подходят по условию");
        }
        if (point2)
        {
            Console.WriteLine("Все цифры подходят по условию");
        }
        else
        {
            Console.WriteLine("Не все числа подходят по условию");
        }

    }
}