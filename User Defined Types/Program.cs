using System;

//ref link:https://www.youtube.com/watch?v=HY8YIU_xCCA&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=2
//

/*
 * static void P(this object o)
{
    Console.WriteLine(o);
}
 * 
 */

class Cow
{
    int numSteaks;
    int mooCount;
    double pounds;
    public void Moo() 
    { 
        "Moo".P(); 
        mooCount++;
    }

}



class MainClass
{
    static void Main()
    {
        Cow betsy = new Cow();
        betsy.Moo();
    }
    
}

