﻿Console.WriteLine("Введите координату x точки A:");
    int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y точки A:");
    int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z точки A:");
    int Az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x точки B:");
    int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y точки B:");    
    int By = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z точки B:");
    int Bz = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(2,(Bx-Ax))+Math.Pow(2,(By-Ay))+Math.Pow(2,(Bz-Az)));
Console.WriteLine($"Координаты точки А :({Ax},{Ay},{Az})");
Console.WriteLine($"Координаты точки B :({Bx},{By},{Bz})");
Console.WriteLine($"Расстояние между точками А и В: " + distance);
