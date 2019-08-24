static void Main()
    {
      
      Tomada2Pinos Tomada2Pinos = new Adapter();
      Tomada2Pinos.Request();
 
          Console.ReadKey();
    }
  }
  
  class Tomada2Pinos
  {
    public virtual void Request()
    {
      Console.WriteLine("Tomada d dois pinos");
    }
  }

  class Adapter : Tomada2Pinos

  {
    private Adapter _tomada2Pinos = new Tomada2Pinos();
 
    public override void Request()
    {
      
      _tomada2Pinos.SpecificRequest();
    }
  }

  class Tomada3Pinos

  {
    public void SpecificRequest()
    {
      Console.WriteLine("Tomada3Pinos");
    }
  }
}
