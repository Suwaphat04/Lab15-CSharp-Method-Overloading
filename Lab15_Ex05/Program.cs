using static System.Console;

Derived_2 d2 = new Derived_2();
Base b = (Base) d2;
Derived_1 d1 = (Derived_1) d2;

b.A();  // Output: Derived_2.A()
d1.A(); // Output: Derived_2.A()
d2.A(); // Output: Derived_2.A()

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()");
    }
}
class Derived_1 : Base
{
    public override void A()
    {
        WriteLine("Derived_1.A()");
    }
}
class Derived_2 : Derived_1
{
    public override void A()
    {
        WriteLine("Derived_2.A()");
    }
}
