class MainApp
    {
        public static void Main()
        {
            
            FabricaContinente africa = new ContinenteAfrica();
            Animal AnimalContinente = new Animal(africa);
            
            
            FabricaContinente america = new ContinenteAmerica();
            AnimalContinente = new Animal(america);

            FabricaContinente europa = new ContinenteEuropa();
            AnimalContinente = new Animal(europa);
            
        }
    }

    abstract class FabricaContinente
    {
        public abstract Gato CreateGato();
        public abstract Cachorro CreateCachorro();
        public abstract Peixe CreatePeixe();
        public abstract Papagaio CreatePapagaio();
        
    }

    class ContinenteAfrica : FabricaContinente
    {
        public override Gato CreateGato()
        {
            return new Gato('Azul');
        }
        public override Cachorro CreateCachorro()
        {
            return new Cachorro('Verde');
        }
        public override Peixe CreatePeixe()
        {
            return new Peixe('Vermelho');
        }

        public override Papagaio CreatePapagaio()
        {
            return new Papagaio('Azul');
        }

    }
    
    class ContinenteAmerica : FabricaContinente
    {
        public override Gato CreateGato()
        {
            return new Gato('Vermelho');
        }
        public override Cachorro CreateCachorro()
        {
            return new Cachorro('Vermelho');
        }
        public override Peixe CreatePeixe()
        {
            return new Peixe('Vermelho');
        }

        public override Papagaio CreatePapagaio()
        {
            return new Papagaio('Vermelho');
        }

    }

    class ContinenteEuropa : FabricaContinente
    {
        public override Gato CreateGato()
        {
            return new Gato('azul');
        }
        public override Cachorro CreateCachorro()
        {
            return new Cachorro('verde');
        }
        public override Peixe CreatePeixe()
        {
            return new Peixe('verde');
        }

        public override Papagaio CreatePapagaio()
        {
            return new Papagaio('azul');
        }

    }

    class Gato : Gato
    {
        var cor;
    }
    class Cachorro : Cachorro
    {
        var cor;
    }
  
    class Peixe : Peixe
    {
        var cor;
    }
    class Papagaio : Papagaio
    {
        var cor;
    }  

    
    class Animal
    {
        private Gato _Gato;
        private Cachorro _Cachorro;
        private Peixe _Peixe;
        private Papagaio _Papagaio;
        

        // Constructor
        public Animal(FabricaContinente factory)
        {
            _Cachorro = factory.CreateCachorro();
            _Gato = factory.CreateGato();
            _Peixe = factory.CreatePeixe();
            _Papagaio = factory.CreatePapagaio();
       
        }

    }
