/* По 3м сторонам треугольника определить тип треугольника - тупоугольный, остроугольный, прямоугольный*/

Console.WriteLine("Введите число - 1-ю сторону треугольника");
double a = GetNumber();

Console.WriteLine("Введите число - 2-ю сторону треугольника");
double b = GetNumber();

Console.WriteLine("Введите число - 3-ю сторону треугольника");
double c = GetNumber();

List<double> lst = new List<double>() { a,b, c };
lst.Sort(); // сортируем по возрастанию


Console.WriteLine(DefineTriangle(lst));

static double GetNumber()
{
    if (!double.TryParse(Console.ReadLine(), out double A))
    {
        Console.WriteLine("Было введено не число. Введите еще раз число.");

        A = GetNumber();
    }
    return A;
}

static TriangleType DefineTriangle(List<double> lst)
{
    TriangleType res =TriangleType.NoDef;

    double bigS = lst[2] * lst[2];
    double s1 = lst[0] * lst[0];
    double s2 = lst[1] * lst[1];

    //если сумма двух сторон меньше чем наибольшая сторона, то это не треугольник
    if (lst[2] > lst[0] + lst[1])
        return res;
    
    if (bigS > s1 + s2)
    {
        res= TriangleType.Tupoug; 
    }
    else if (bigS < s1 + s2 )
    {
        res= TriangleType.Ostroug;      
    }
    else if (bigS == s1 + s2)
    {
        res = TriangleType.Pryamoug;        
    }
        
    return res;
}

enum TriangleType
{
    Tupoug,          //тупоугольный
    Ostroug,         //остроугольный
    Pryamoug,        //прямоугольный
    NoDef            // не определен, не является треугольникоим
}
