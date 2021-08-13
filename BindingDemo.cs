using System;

class CParent
{
    public int N;
    public   virtual  void Foo()
    {
        Console.WriteLine("In Parent");
    }
}
class CChild : CParent
{
    public new int N;
    public new virtual  void Foo()
    {
        Console.WriteLine("In Child");
    }
}
class CGrandChild : CChild
{
    public override void Foo()
    {
        Console.WriteLine("In GrandChild");
    }
}
class BindingDemoProgram
{
    static void Main(string[] args)
    {
        CParent p = new CChild();
        p.Foo();
       // p.N = 10;
        ((CChild)p).N = 10;
    }
}