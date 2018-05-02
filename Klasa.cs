﻿using System.Collections.Generic;

public static class Klasa {

	public static void MixElements<T>(this List<T> list)  
	{  
		System.Random rnd = new System.Random();  
   		int n = list.Count;
   		while (n > 1) {  
        n--;  
        int k = rnd.Next(n + 1);  
        T value = list[k];  
        list[k] = list[n];  
        list[n] = value;  
    }  
	}
}
