using System.Collections.Generic;

public static class Anagram {

	// Sprawdza czy dwa wyrazy są swoimi anagramami
	// Wykorzystanie:
	// bool wynik = wyrazPierwszy.IsAnagram(wyrazDrugi); // domyślnie bierze pod uwagę wielkośc liter
	// Bez brania pod uwage wielkości lier:
	// bool wynik = wyrazPierwszy.IsAnagram(wyrazDrugi, false);
	public static bool IsAnagram(this string a, string b, bool letterSize = true)
	{
		if(a.Length == b.Length)
		{
			if(!letterSize)
			{
				a=a.ToLower();
				b=b.ToLower();
			}

			// Sortowanie stringów, można zamienić na dowolny inny algorytm sortujący
			a = SortString(a);
			b = SortString(b);
		}
		else return false; // jeżeli długość się nie zgadza zwraca 'false'
		return a==b;
	}

	// Sortowanie
	private static string SortString(string parametr)
	{
    	char[] characters = parametr.ToCharArray();
    	System.Array.Sort(characters);
    	return new string(characters);
	}
}


