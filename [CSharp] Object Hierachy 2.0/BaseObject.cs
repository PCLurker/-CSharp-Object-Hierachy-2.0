using System;

namespace _CSharp__Object_Hierachy_2._0
{
    class BaseObject
    {
        public ContainerObject CO { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="CO">Pass in "new ContainerObject()" for a default value.</param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public BaseObject(ContainerObject CO, int A = 0, int B = 0)
        {
            this.CO = CO;
            this.A = A;
            this.B = B;
            Console.WriteLine("BaseObject created.");
        }

        /// <summary>
        /// Default constructor. All properties initialized with proper default values
        /// </summary>
        public BaseObject() : this(new ContainerObject()) { }

        /// <summary>
        /// Deep copy an existing object
        /// </summary>
        /// <param name="C"></param>
        public BaseObject(BaseObject C): this(C.CO?.Clone(), C.A, C.B) { }

        /// <summary>
        /// Chain to copy constructor
        /// </summary>
        /// <returns>A deep clone of this object</returns>
        public virtual BaseObject Clone() { return new BaseObject(this); }
    }
}
