/*  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
*/

string[] MakeCoeffArray()
{
    Console.WriteLine("Введите коэффициенты k и b через запятую: ");

    string strCoeff = Console.ReadLine();
    string[] arrCoeff = strCoeff.Split(',');
    return arrCoeff;
}

double[]? CenterCoords(string[] arr1, string[] arr2)
{
    double k1 = double.Parse(arr1[0]);
    double b1 = double.Parse(arr1[1]);

    double k2 = double.Parse(arr2[0]);
    double b2 = double.Parse(arr2[1]);

    double[] coordsArr = new double[2];

    if (k1 == k2)
    {
        return null;
    }

    coordsArr[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
    coordsArr[1] = Math.Round(k1 * coordsArr[0] + b1, 2);

    return coordsArr;
}

Console.WriteLine("Первая прямая");
string[] arrCoeff1 = MakeCoeffArray();

Console.WriteLine("Вторая прямая");
string[] arrCoeff2 = MakeCoeffArray();

var coords = CenterCoords(arrCoeff1, arrCoeff2);

if (coords == null)
{
    Console.WriteLine("Прямые с заданными коэффициентами не пересекаются (параллельны или совпадают).");
}
else
{
    Console.WriteLine($"Координаты точки пересечения прямых с заданными коэффициентами: ({coords[0]}, {coords[1]}).");
}