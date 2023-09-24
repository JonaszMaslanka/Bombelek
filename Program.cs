// See https://aka.ms/new-console-template for more information
using System;
//Zmienne

int[] zbiory = { 9,5,2,0,6};
int[] newSeries = new int[zbiory.Length];

// Program
foreach (int item in zbiory)
{

    Console.Write("Ciag wprowadzony:  " + item + "\n");
}

Bombelek(zbiory);
kopiuj(zbiory, newSeries);
Console.Write("Zdumiewający efekt koncowy: ");

/*foreach (var item in newSeries)
{

    Console.Write(item + " ");
}*/

// Funkcje
static int[] Bombelek(int[] series)
{
    bool koniec = true;
    while (koniec == true)
    {
        int x = 0;
        for (int i = 1; i <= series.Length - 1; i++)
        {
            if (series[i-1] > series[i])
            {
                (series[i-1], series[i]) = (series[i], series[i-1]);                
            }
            else
            {
                x++;
            }
        }
        //foreach (int item in series)
        //{

           // Console.Write(item + " ");
        //}
        if (x == series.Length-1)
        {
            koniec = false;
        }
        //Console.Write("\n");
    }
    //return new int[series.Length];
    return series;
}

static int[] kopiuj(int[] copyFrom, int[] copyTo)
{
    for(int i = 0; i < copyFrom.Length; i++)
    {
        copyTo[i] = copyFrom[i];
    }
    return copyTo;

}
