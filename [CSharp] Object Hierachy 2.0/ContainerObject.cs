using System;

namespace _CSharp__Object_Hierachy_2._0
{
    class ContainerObject
    {
        public InnerObject I { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="I">Pass in "new InnerObject()" for a default value.</param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public ContainerObject(InnerObject I, int A = 0, int B = 0)
        {
            this.I = I;
            this.A = A;
            this.B = B;
            // Debug
            Console.WriteLine("ContainerObject created.");
        }

        /// <summary>
        /// All properties initialized with proper default values.
        /// </summary>
        public ContainerObject() : this(new InnerObject()) { }

        /// <summary>
        /// Copy constructor. Chain to default constructor
        /// </summary>
        /// <param name="C"></param>
        public ContainerObject(ContainerObject C) : this(C.I?.Clone(), C.A, C.B) { }

        /// <summary>
        /// Return a deep copy of this object. Chain to copy constructor
        /// </summary>
        /// <returns></returns>
        public virtual ContainerObject Clone() { return new ContainerObject(this); }
    }

    //class ContainerObject
    //{
    //    public InnerObject I { get; set; }
    //    public int A { get; set; }
    //    public int B { get; set; }
    //    public ContainerObject(Dictionary<string, object> D)
    //    {
    //        if (D.TryGetValue("I", out object i_)) this.I = (InnerObject)i_;
    //        else this.I = new InnerObject();
    //        if (D.TryGetValue("A", out object a_)) this.A = (int)a_;
    //        else this.A = 0;
    //        if (D.TryGetValue("B", out object b_)) this.B = (int)b_;
    //        else this.B = 0;
    //    }
    //    /// <summary>
    //    /// Copy constructor. Chain to default constructor
    //    /// </summary>
    //    /// <param name="C"></param>
    //    public ContainerObject(ContainerObject C) : this(new Dictionary<string, object> { { "I", C.I?.Clone() }, { "A", C.A }, { "B", C.B } }) { }
    //    /// <summary>
    //    /// Return a deep copy of this object. Chain to copy constructor
    //    /// </summary>
    //    /// <returns></returns>
    //    public virtual ContainerObject Clone() { return new ContainerObject(this); }
    //}

}
