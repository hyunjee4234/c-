using System;

class Parent
{
    public int PubA;
    private int PriA;
    protected int ProA;
    public Parent()
    {
    }
    public Parent(int priA, int proA, int pubA)
    {
        PriA = priA;
        ProA = proA;
        PubA = pubA;
    }
}

class Child : Parent
{
    public int PubB;
    public Child()
    {
     }
    public Child(int priA, int proA, int pubA, int pubB)
        : base(priA, proA, pubA)
    {
        //PriA = priA;
        //ProA = proA;
        //PubA = pubA;
        PubB = pubB;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parent p1,p2;
        Child c; 
        p1 = new Parent();
        p2 = null;

        Parent p = p2 ?? p1;
        if (p2 == null)
            p = p1;
        else
            p = p2;

        c = p as Child;

        if (p is Child)  //If p is ref to object of Child or GrandChild 
            c = (Child)p;
        else
            c = null;

        Console.WriteLine(c == null);

    }
}

