//1.11. Автомобіль, поїзд, транспортний засіб, експрес. 
//2 - До побудованої ієрархії класів з завдання 1 додати
//конструктори та деструктори в який виводити повідомлення в консоль. 

namespace Lab5 {
class TransZasib
{
    protected double maxSpeed;

    public TransZasib()
    {
        Console.WriteLine("TransZasib constructor");
        maxSpeed = 0;
    }

    public TransZasib(double speed)
    {
        Console.WriteLine("TransZasib constructor");
        maxSpeed = speed;
    }

    ~TransZasib()
    {
        Console.WriteLine("TransZasib destructor");
    }
    

    public void Show()
    {
        Console.WriteLine($"Max Speed: {maxSpeed}");
    }
    
}

class Auto : TransZasib
{
    private string model;
    public Auto()
    {
        Console.WriteLine("Auto constructor");
        model = "auto";
        maxSpeed = 250;
    }

    public Auto(double maxSpeed)
    {
        Console.WriteLine("Auto constructor");
        model = "auto";
        this.maxSpeed = maxSpeed;
    }

    public Auto(double speed, string mod)
    {
        Console.WriteLine("Auto constructor");
        model = mod;
        maxSpeed = speed;
        
    }
    
    ~Auto()
    {
        Console.WriteLine("Auto destructor");
    }

}
    
class Train : TransZasib
{
    private int places;
    public Train()
    {
        Console.WriteLine("Train constructor");
        maxSpeed = 150;
        places = 50;
    }

    public Train(double maxSpeed)
    {
        Console.WriteLine("Train constructor");
        this.maxSpeed = maxSpeed;
        places = 50;
    }

    public Train(double maxSpeed, int place)
    {
        Console.WriteLine("Train constructor");
        this.maxSpeed = maxSpeed;
        places = place;
    }
    
    ~Train()
    {
        Console.WriteLine("Train destructor");
    }

}
    
class Express : TransZasib
{
    private string type;
    public Express()
    {
        Console.WriteLine("Express constructor");
        maxSpeed = 300;
        type = "paroplav";
    }

    public Express(double maxSpeed)
    {
        Console.WriteLine("Express constructor");
        this.maxSpeed = maxSpeed;
        type = "paroplav";
    }
    
    public Express(double maxSpeed, string t)
    {
        Console.WriteLine("Express constructor");
        this.maxSpeed = maxSpeed;
        type = t;
    }

    ~Express()
    {
        Console.WriteLine("Express destructor");
    }

}

//3.1 Створити абстрактний клас Figure з методами
//обчислення площі периметра, а також методом,
//що виводять інформацію про фігуру на екран.
//Створити похідні класи: Rectangle (прямокутник), Circle (коло),
//Triangle (трикутник) зі своїми методами обчислення площі й
//периметра. Створити масив n фігур і
//вивести повну інформацію про фігури на екран.

internal abstract class Figure
    {
        public abstract double Square();
        public abstract double Perimetr();
        public abstract void Print();

    }

class Rectangle : Figure
{
    private double a, b;

    public Rectangle()
    {
        a = 0;
        b = 0;
    }

    public Rectangle(double num)
    {
        a = num;
        b = num;
    }

    public Rectangle(double a_, double b_)
    {
        a = a_;
        b = b_;
    }
    
    public override double Square()
    {
        return a * b;
    }

    public override double Perimetr()
    {
        return a + a + b + b;
    }

    public override void Print()
    {
        Console.WriteLine("Rectangle");
        Console.WriteLine($"A: {a}, B: {b}");
        Console.WriteLine($"S: {Square()}, P: {Perimetr()}");
    }
}

class Circle : Figure
{
    private double R;

    public Circle()
    {
        R = 0;
    }

    public Circle(double r)
    {
        R = r;
    }
    
    
    public override double Square()
    {
        return Math.PI * R*R;
    }

    public override double Perimetr()
    {
        return 2*Math.PI*R;
    }

    public override void Print()
    {
        Console.WriteLine("Circle");
        Console.WriteLine($"R: {R}");
        Console.WriteLine($"S: {Square()}, C: {Perimetr()}");
    }
}

class Triangle : Figure
{
    private double a, b, c;

    public Triangle()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    public Triangle(double side)
    {
        a = side;
        b = side;
        c = side;
    }

    public Triangle(double A, double B, double C)
    {
        a = A;
        b = B;
        c = C;
    }
    public override double Square()
    {
        double p = Perimetr() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public override double Perimetr()
    {
        return a + b + c;
    }

    public override void Print()
    {
        Console.WriteLine("Triangle");
        Console.WriteLine($"A: {a}, B: {b}, C: {c}");
        Console.WriteLine($"S: {Square()}, P: {Perimetr()}");
    }
}

static class Program
{
    static void Main()
    {
        //-----------------
        TransZasib transZasib = new TransZasib();
        transZasib.Show();
        Auto auto = new Auto(120);
        auto.Show();
        Train train = new Train();
        train.Show();
        Express express = new Express(400);
        express.Show();
        //-----------------
        Figure[] figures = new Figure[3];
        figures[0] = new Rectangle(2, 4);
        figures[1] = new Circle(5);
        figures[2] = new Triangle(3,3,3);
        for (int i = 0; i < 3; i++)
        {
            figures[i].Print();
            Console.WriteLine();
        }

    }
}
}
