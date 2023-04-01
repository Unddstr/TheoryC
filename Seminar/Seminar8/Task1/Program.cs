﻿// Дополнительная задача(Площадь треугольника)
Console.Clear();
int[] coord = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int x1 = coord[0];
int y1 = coord[1];
int x2 = coord[2];
int y2 = coord[3];
int x3 = coord[4];
int y3 = coord[5];
double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
double C = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double p = (A + B + C) / 2;
double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
Console.WriteLine(S);
