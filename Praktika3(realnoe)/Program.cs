class Rectangle
{
    private int a, b;

    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public bool IsSquare
    {
        get { return a == b; }
    }

    public int this[int index]
    {
        get
        {
            if (index == 0) return a;
            if (index == 1) return b;
            throw new IndexOutOfRangeException("Индекс должен быть 0 или 1");
        }
        set
        {
            if (index == 0) a = value;
            else if (index == 1) b = value;
            else throw new IndexOutOfRangeException("Индекс должен быть 0 или 1");
        }
    }

    public void Print()
    {
        Console.WriteLine("Стороны: a = {0}, b = {1}", a, b);
    }

    public int Perimeter()
    {
        return 2 * (a + b);
    }

    public int Area()
    {
        return a * b;
    }

    public static Rectangle operator ++(Rectangle r)
    {
        r.a++;
        r.b++;
        return r;
    }

    public static Rectangle operator --(Rectangle r)
    {
        r.a--;
        r.b--;
        return r;
    }

    public static Rectangle operator *(Rectangle r, int k)
    {
        r.a *= k;
        r.b *= k;
        return r;
    }

    public static Rectangle operator *(int k, Rectangle r)
    {
        return r * k;
    }

    public static bool operator true(Rectangle r)
    {
        return r.IsSquare;
    }

    public static bool operator false(Rectangle r)
    {
        return !r.IsSquare;
    }
}

class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle(4, 4);

        r.Print();
        Console.WriteLine("Периметр: " + r.Perimeter());
        Console.WriteLine("Площадь: " + r.Area());
        Console.WriteLine("Квадрат? " + r.IsSquare);

        if (r)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");

        r[0] = 5;
        r[1] = 3;
        r.Print();

        ++r;
        Console.WriteLine("После ++:");
        r.Print();

        r = r * 2;
        Console.WriteLine("После * 2:");
        r.Print();

        Console.WriteLine("r[0] = " + r[0]);
        Console.WriteLine("r[1] = " + r[1]);
    }
}
//Что делает класс Rectangle
//Поля:
//a, b — длины сторон прямоугольника.
//Конструктор:
//Rectangle(int a, int b) — создаёт прямоугольник с заданными сторонами.
//Свойства:
//A — получить/изменить сторону a.
//B — получить/изменить сторону b.
//IsSquare — только для чтения; возвращает true, если a == b, то есть прямоугольник является квадратом.
//Индексатор:
//r[0] — доступ к стороне a.
//r[1] — доступ к стороне b.
//При другом индексе выбрасывается ошибка IndexOutOfRangeException.
//Методы:
//Print() — выводит длины сторон на экран.
//Perimeter() — возвращает периметр: 2 * (a + b).
//Area() — возвращает площадь: a * b.
//Перегрузка операторов:
//++ — увеличивает обе стороны на 1.
//-- — уменьшает обе стороны на 1.
//true / false — объект считается true, если это квадрат, иначе false.
//Что делает Main
//Создаётся прямоугольник 4 × 4.
//Выводятся его стороны, периметр, площадь и проверка на квадрат.
//Через if (r) проверяется оператор true: так как стороны равны, выводится true.
//Через индексатор сторонам присваиваются значения 5 и 3.
//Выводятся новые стороны.
//Выполняется оператор ++: стороны становятся 6 и 4.
//Выполняется умножение на 2: стороны становятся 12 и 8.
//Выводятся значения r[0] и r[1].Что делает класс Rectangle