using System;

struct information
{
    private string colour;
    public string Colour
    {
        get { return colour; }
        set { colour = value; }
    }

    private double hight;
    public double Hight
    {
        set { hight = value; }
        get { return hight; }
    }

    private string gender;
    public string Gender
    {
        set { gender = value; }
        get { return gender; }
    }

    public information(string colour, double hight, string gender)
    {
        //带有参数的构造函数，必须对所有变量赋值！！
        this.colour = colour;
        this.gender = gender;
        this.hight = hight;
    }
}
class Program
{
    static void Main(string[] args)
    {
        information info = new information("red", 180.1, "Man");
        information info1 = info;
        Console.WriteLine("colour: {0}\nhight: {1}\ngender: {2} ", info1.Colour, info1.Hight, info1.Gender);
    }
}