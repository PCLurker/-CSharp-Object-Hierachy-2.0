using System;

namespace _CSharp__Object_Hierachy_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ContainerObject Test1 = new ContainerObject(new Dictionary<string, object> { { "A", 1 } });
            ContainerObject Test1 = new ContainerObject();
            Test1.I.A = 6;

            BaseObject B = new BaseObject(new ContainerObject(new InnerObject(A: 12, B: 13, Note: "IO Note 1"), A: 14, B: 15), A: 16, B: 17);

            Derived1Object D10 = new Derived1Object(B, 45, 12);

            Derived1Object D11 = (Derived1Object)D10.Clone();

            D11.D = 60;

            Derived2Object D20 = new Derived2Object(D11, new ContainerObject(), 561, -23);
        }
    }
}
