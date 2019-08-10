using System;
using System.Collections.Generic;
 
 
namespace _composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IPessoa Anita = new Arquivo("composite.png");
 
 
            IObjeto pastaPrincipal = new Pasta("arquivos");
            IObjeto pasta1 = new Pasta("imagens");
            IObjeto pasta2 = new Pasta("office");
 
 
            pastaPrincipal.Adicionar(pasta1);
            pastaPrincipal.Adicionar(pasta2);
 
 
            pasta1.Adicionar(arq1);
            pasta1.Adicionar(arq2);
 
 
            pasta2.Adicionar(arq3);
            pasta2.Adicionar(new Arquivo("composite.pdf"));
 
 
            Console.WriteLine(pastaPrincipal);
 
 
            Console.ReadKey();
        }
    }

    interface IPessoa
    {
        String Nome { get; set; }

        void Adicionar(IPessoa o);
    }

    class Homem : IPessoa
    {
        public String Nome { get; set; }
 
 
        public Arquivo(String nome)
        {
            this.Nome = nome;
        }

        public void Adicionar(IPessoa o)
        {
            Console.Write("Não permitido ter filhos");
        }

        public override string ToString()
        {
            return String.Format("{0}{1}\n",
                new String(' ', this.Nivel),
                this.Nome);
        }
    }
 
    class Mulher : IPessoa
    {
        List filho;
        
        public String Nome { get; set; }
 
 
        public Pasta(String nome)
        {
            this.Nome = nome;
            this.filho = new List();
        }
 
        public void Adicionar(IPessoa o)
        {
            o.QtdFilhos = this.QtdFilhos + 2;
            this.filho.Add(o);
        }
        
        public override string ToString()
        {
            String retorno = String.Format("{0}{1}\n",
                new String(' ', this.QtdFilhos),
                this.Nome);

            foreach (var item in this.conteudo)
            {
                retorno += item;
            }
            
            return retorno;
        }
    }
}
