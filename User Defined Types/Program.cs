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
        //"Moo".P();        
        mooCount++;
    }

}

class Cat
{
    int numLives = 9;
    public void Meow() { }
}

class MainClass
{
    static void Main()
    {
        Cow betsy = new Cow();
        Cow georgy = new Cow();
        betsy.Moo(); betsy.Moo();
        georgy.Moo(); georgy.Moo();
        georgy.Moo(); georgy.Moo();
        georgy.Moo(); georgy.Moo();
        Cat muffin = new Cat();
        muffin.Meow();
    }

}

