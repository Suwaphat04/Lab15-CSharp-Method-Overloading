using static System.Console;

Derived_2 d2 = new Derived_2();
Base b = (Base) d2;
Derived_1 d1 = (Derived_1) d2;

b.A();  // Output: Derived_1.A() เพราะ Base หรือ Derived_1 ไม่มีการซ่อน A()
d1.A(); // Output: Derived_1.A() เพราะ d1 ยังเป็น Derived_1
d2.A(); // Output: Derived_2.A() เพราะ d2 ใช้เมธอดที่ถูกซ่อน (new)

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
    public new void A() // ซ่อนเมธอด A() ของ Derived_1
    {
        WriteLine("Derived_2.A()");
    }
}

