using System;

namespace _CSharp__Object_Hierachy_2._0
{
    class InnerObject
    {
        public int A { get; set; }
        public int B { get; set; }
        public string Note { get; set; }

        public InnerObject(int A = 0, int B = 0, string Note = "")
        {
            this.A = A;
            this.B = B;
            this.Note = Note;
            // Debug
            Console.WriteLine("InnerObject created.");
        }
        public InnerObject(InnerObject C): this(C.A, C.B, C.Note) { }
        public virtual InnerObject Clone() { return new InnerObject(this); }
    }
}
