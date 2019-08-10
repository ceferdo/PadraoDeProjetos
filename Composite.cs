class Program
    {
        static void Main(string[] args)
        {
            IPessoa pai = new Homem("paulo");
          
            IPessoa mae = new Mulher("Maria");
            IPessoa filho1 = new Homem("filho1");
            IPessoa filho2 = new Mulher("filho2");
            
            mae.Filho(filho1);
            mae.Filho(filho2);
 
            filho2.Filho(new Homem("Carlos"));
 
            Console.WriteLine(mae);
            Console.ReadKey();
        }
    }

interface IPessoa
    {
        String Nome { get; set; }
        
        void Filho(IPessoa o);
    }

    class Homem : IPessoa
    {
        public String Nome { get; set; }
 
        public Homem(String nome)
        {
            this.Nome = nome;
        }
 
        public void Filho(IPessoa o)
        {
            Console.Write("não gera filho");
        }
 
        public override string ToString()
        {
            return String.Format("{0}\n",this.Nome);
        }
    }

    class Mulher : IPessoa
    {
        List filho;
 
        public String Nome { get; set; }
        public int QtFilho { get; set; }
 
        public Mulher(String nome)
        {
            this.Nome = nome;
            this.filho = new List();
        }
        
        public void Filho(IPessoa o)
        {
            o.QtFilho = this.QtFilho + 2;
            this.filho.Add(o);
        }
 
        public override string ToString()
        {
            String retorno = String.Format("{0}{1}\n",
                new String(' ', this.QtFilho),
                this.Nome);
            foreach (var item in this.conteudo)
            {
                retorno += item;
            }
            return retorno;
        }
    }
