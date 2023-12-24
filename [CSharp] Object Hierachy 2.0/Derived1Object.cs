using System;

namespace _CSharp__Object_Hierachy_2._0
{
    class Derived1Object : BaseObject
    {
        public int C { get; set; }
        public int D { get; set; }

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="CO">Pass in "new ContainerObject()" for a default value.</param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        public Derived1Object(ContainerObject CO, int A = 0, int B = 0, int C = 0, int D = 0) : base(CO, A, B)
        {
            this.C = C;
            this.D = D;
            Console.WriteLine("Derived1Object created.");
        }

        /// <summary>
        /// Construct the object using an existing BaseObject object to initialize this object's base BaseObject.
        /// </summary>
        /// <param name="Base">Should be passed as a reference instead of newly allocating vie Clone method. Must not be null.</param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        public Derived1Object(BaseObject Base, int C = 0, int D = 0) : this(Base.CO?.Clone(), Base.A, Base.B, C, D) { }

        /// <summary>
        /// Default constructor. All properties initialized with proper default values
        /// </summary>
        public Derived1Object() : this(new ContainerObject()) { }

        /// <summary>
        /// Deep copy an existing object
        /// </summary>
        /// <param name="C"></param>
        public Derived1Object(Derived1Object C) : this(C.CO?.Clone(), C.A, C.B, C.C, C.D) { }

        /// <summary>
        /// Chain to copy constructor
        /// </summary>
        /// <returns>A deep clone of this object</returns>
        public override BaseObject Clone() { return new Derived1Object(this); }
    }
}
