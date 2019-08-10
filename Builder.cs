public class Casa
{
    
    public int quartos { get; set; }
    
    public int andares { get; set; }

    public Casa(int quartos, int andares)
    {
        quartos = quartos;
        andares = andares;
    }
}


public interface CasaBuilder
{
    int andares { get; set; }
    int quartos { get; set; }

    Casa GetResult();
}


public class MinhaCasaBuilder : CasaBuilder
{
   public int andares { get; set; }
    public int quartos { get; set; }

    public Casa GetResult()
    {
        return casa = new Casa(quartos, andares) ;        
    }
}


public class PadraoSimplesBuilder
{
    private CasaBuilder _builder;
    public PadraoSimplesBuilder(CasaBuilder builder) 
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.Andares = 1;
        _builder.Quartos = 2;
    }
}
public class ElevadoBuilder
{
    private CasaBuilder _builder;
    public ElevadoBuilder(CasaBuilder builder) 
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.Andares = 3;
        _builder.Quartos = 5;
    }
}

public class Client
{
    public void MinhaCasaMinhaVida()
    {

        var builder = new MinhaCasaBuilder();
        var Cliente = new PadraoSimplesBuilder(builder);

        Cliente.Construct();
        Casa minhaCasa = builder.GetResult();
    }
}
