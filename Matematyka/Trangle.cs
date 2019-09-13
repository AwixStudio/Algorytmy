using System.Collections;
using System.Collections.Generic;
using System;

public static class Trangle {

	// Sprawdza czy z odcinków podanej długości można zbudować trójkąt
	// Wykorzystanie:
	// bool wynik = CanBeTrangle(dOdcinka1, dOdcinka2, dOdcink3);
	public static bool CanBeTrangle(double a, double b, double c)
	{
		return (a+b>c && b+c>a && a+c>b);
	}

	// Sprawdza czy z podanych trzech punktów można zbudować trójkąt
	// Wykorzystanie:
	// bool wynik = CanBeTrangle(aX, aY, bX, bY, cX, cY);
	public static bool CanBeTrangle(int aX, int aY, int bX, int bY, int cX, int cY)
	{
		double a = Math.Sqrt((Math.Pow(aX-bX,2)+Math.Pow(aY-bY,2))); 
		double b = Math.Sqrt((Math.Pow(bX-cX,2)+Math.Pow(bY-cY,2))); 
		double c = Math.Sqrt((Math.Pow(cX-aX,2)+Math.Pow(cY-aY,2)));
		return CanBeTrangle(a,b,c); 
	}

	// Okresla jakiego typu ze względu na boki jest trojkąt zbudowany z podanych odcinków
	// 0 - nie istenieje
	// 1 - równoboczny
	// 2 - równoramienny
	// 3 - różnoboczny
	public static int TrangleType(double a, double b, double c)
	{
		if(CanBeTrangle(a,b,c))
		{
			if(a==b && b==c)
			return 1;
			if(a==b || b==c || c==a)
			return 2;
			return 3;

		}
		return 0;
	}
}
