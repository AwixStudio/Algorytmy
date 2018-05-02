using System;

public static class Prime  {

	// Sprawdza czy dana liczba jest liczbą pierwszą
	// Wykorzystanie:
	// bool wynik = liczba.IsPrime();
	public static bool IsPrime(this int a)
	{
		if(a <= 1)
		return false;
		if(a == 2)
		return true;
		if(a%2 == 0) // ze względów optymalizacyjnych odrazu odrzucamy liczby parzyste
		return false;

		for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(a)); i+=2)
		if (a%i == 0)
		return false;
   		return true;  
	}
}
