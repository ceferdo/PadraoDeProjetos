class Program
    {
        static void Main(string[] args)
        {
            Comida s = new Comida();
 
            Burger b;
            b = new Burger(s);
 
            Console.WriteLine("Burger com:");
            Console.WriteLine("{0:c}", b.Ingrediente);

            Console.WriteLine();
  
            Pizza p;
            p = new Pizza(s);
 
            Console.WriteLine("Pizza Com:");
            Console.WriteLine("{0:c}", p.Ingrediente);
 
            Console.ReadKey();
        }
    }

    interface IComida
    {
        string Ingrediente { get; }
    }

    sealed class Comida : IComida
    {
        public string Ingrediente
        {
            get
            {
                return "";
            }
        }
    }

    class Burger : IComida
    {
        IComida s;

        public Burger(IComida s)
        {
            this.s = s;
        }
        public string Ingrediente
        {
            get
            {
                return this.s.Ingrediente + "Bacon";
            }
        }
    }
    
    class Pizza : IComida
    {
        IComida s;
        public Pizza(IComida s)
        {
            this.s = s;
        }
        
        public string Ingrediente
        {
            get
            {
                return this.s.Ingrediente + "Cheddar";
            }
        }
    }
    
    class Massa : IComida
    {
        IComida s;
        public Massa(IComida s)
        {
            this.s = s;
        }
        public string Ingrediente
        {
            get
            {
                return this.s.Ingrediente + "Catupiry";
            }
        }
    }
}
