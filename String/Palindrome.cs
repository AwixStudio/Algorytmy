using System.Collections;
using System.Collections.Generic;

public static class Palindrome {

	// Sprawdza czy dany wyraz jest palindromem
	// Wykorzystanie:
	// bool wynik = tekst.IsPalindrome();
	public static bool IsPalindrome(this string text)
	{
		text=text.DeleteChars();
		for(int i=0, j=text.Length-1; i<(int)text.Length; i++, j--)
		if(text[i]!=text[j])
		return false;
		return true;
	}

	// Zwraca dany tekst z usuniętymi spacjami
	private static string DeleteChars(this string text)
	{
		string result = "";
		
		for(int i=0; i<text.Length; i++)
		if(text[i] != ' ')
		result += text[i];
		
		return result;
	}

	// Zwraca dany tekst z usuniętymi znakami podanymi w argumencie
	// Wykorzystanie:
	// string wynik = tekst.DeleteChars(new List<char>{'wartosc1','wartosc2','wartosc3'});
	public static string DeleteChars(this string text, List<char> toDelete)
	{
		string result = "";
		
		for(int i=0; i<text.Length; i++)
		if(!toDelete.Contains(text[i]))
		result += text[i];
		
		return result;
	}
}
