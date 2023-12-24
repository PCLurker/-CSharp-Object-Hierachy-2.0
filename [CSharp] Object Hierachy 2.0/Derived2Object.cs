using System;

namespace _CSharp__Object_Hierachy_2._0
{
    class Derived2Object : Derived1Object
    {
        public int E { get; set; }
        public int F { get; set; }
        public ContainerObject CO2 { get; set; }

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="CO">Pass in "new ContainerObject()" for a default value.</param>
        /// <param name="CO2">Pass in "new ContainerObject()" for a default value.</param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <param name="F"></param>
        public Derived2Object(ContainerObject CO, ContainerObject CO2, int A = 0, int B = 0, int C = 0, int D = 0, int E = 0, int F = 0) : base(CO, A, B, C, D)
        {
            this.CO2 = CO2;
            this.E = E;
            this.F = F;
            Console.WriteLine("Derived2Object created.");
        }

        /// <summary>
        /// Construct the object using an existing BaseObject object to initialize this object's base BaseObject.
        /// </summary>
        /// <param name="Base">Should be passed as a reference instead of newly allocating vie Clone method. Must not be null.</param>
        /// <param name="CO2">Pass in "new ContainerObject()" for a default value.</param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <param name="F"></param>
        public Derived2Object(BaseObject Base, ContainerObject CO2, int C = 0, int D = 0, int E = 0, int F = 0) : this(Base.CO?.Clone(), CO2, Base.A, Base.B, C, D, E, F) { }

        /// <summary>
        /// Construct the object using an existing Derived1Object object to initialize this object's base Derived1Object.
        /// </summary>
        /// <param name="Base">Should be passed as a reference instead of newly allocating vie Clone method. Must not be null.</param>
        /// <param name="CO2">Pass in "new ContainerObject()" for a default value.</param>
        /// <param name="E"></param>
        /// <param name="F"></param>
        public Derived2Object(Derived1Object Base, ContainerObject CO2, int E = 0, int F = 0) : this(Base.CO?.Clone(), CO2, Base.A, Base.B, Base.C, Base.D, E, F) { }

        /// <summary>
        /// Default constructor. All properties initialized with proper default values
        /// </summary>
        public Derived2Object() : this(new ContainerObject(), new ContainerObject()) { }

        /// <summary>
        /// Deep copy an existing object
        /// </summary>
        /// <param name="C"></param>
        public Derived2Object(Derived2Object C) : this(C.CO?.Clone(), C.CO2?.Clone(), C.A, C.B, C.C, C.D, C.E, C.F) { }

        /// <summary>
        /// Chain to copy constructor
        /// </summary>
        /// <returns>A deep clone of this object</returns>
        public override BaseObject Clone() { return new Derived2Object(this); }
    }
}
