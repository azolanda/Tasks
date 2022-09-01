/*  Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
    и находит расстояние между ними в 3D пространстве  */

    double[] GetNumCoords(string[] array)
    {
        double[] numCoords = new double[3]; 

        for(int i = 0; i < array.Length; i++)
        {
            numCoords[i] = double.Parse(array[i]);
        }

        return numCoords;
    }

    double GetDistance(double[] arrayA, double[] arrayB)
    {
        return Math.Round(Math.Sqrt(Math.Pow(arrayA[0] - arrayB[0], 2) + Math.Pow(arrayA[1] - arrayB[1], 2) + Math.Pow(arrayA[2] - arrayB[2], 2)), 2);
    }

    Console.WriteLine("Введите координаты точки А: ");
    string[] arrayCoordsA = Console.ReadLine().Split(',');
    double[] numCoordsA = GetNumCoords(arrayCoordsA);

    Console.WriteLine("Введите координаты точки В: ");
    string[] arrayCoordsB = Console.ReadLine().Split(',');
    double[] numCoordsB = GetNumCoords(arrayCoordsB);

    double distance = GetDistance(numCoordsA, numCoordsB); 

    Console.WriteLine("Расстояние между точками А и В в 3D пространстве: " + distance);

