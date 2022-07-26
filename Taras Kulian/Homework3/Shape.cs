namespace Homework3
{
    public abstract class Shape : IComparable
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"Shape name: {name}";
        }

        public virtual void Output()
        {
            Console.WriteLine(ToString());
        }


        public virtual int CompareTo(object? obj)
        {
            Shape? s1 = obj as Shape;
            if (s1 == null)
                throw new ArgumentException("Object is not a Shape");
            else
                return this.Area().CompareTo(s1.Area());
        }
    }
}
