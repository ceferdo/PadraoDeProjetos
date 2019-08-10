class MainApp
  {
    static void Main()
    {
      // Create two instances and clone each

      Documento p1 = new Documento("1","Nome Arquivo");
      DocumentoDocx c1 = (DocumentoDocx)p1.Clone();
      Console.WriteLine("Extencao : {0}", c1.Id);
    }
  }
  
  abstract class Documento

  {
    private string _id;
    private string _nome;
    
 
    public Documento(string id, string nome)
    {
      this._id = id;
      this._nome = nome;
    }

    public string Id
    {
      get { return _id; }
    }
    public string Nome
    {
      get { return _nome; }
    }
 
    public abstract Documento Clone();
  }
 
  class DocumentoPages : Documento

  {
    // Constructor

    public DocumentoPages(string id, string nome)
      : base(id, nome)
    {
       this._extencao = extencao;
    }
    public void setExtencao(string extencao)
    {
      this._extencao = 'dpg';
    }
 
    public override Documento Clone()
    {
      return (Documento)this.MemberwiseClone();
    }
  }

  class DocumentoDocx : Documento

  {
    // Constructor

    public DocumentoDocx(string id, string nome)
      : base(id, nome)
    {
       this._extencao = extencao;
    }
    public void setExtencao(string extencao)
    {
      this._extencao = 'docx';
    }
 
    public override Documento Clone()
    {
      return (Documento)this.MemberwiseClone();
    }
  }

  class DocumentoPdf : Documento

  {
    // Constructor

    public DocumentoPdf(string id, string nome)
      : base(id, nome)
    {
       this._extencao = extencao;
    }
    public void setExtencao(string extencao)
    {
      this._extencao = 'PDF';
    }
 
    public override Documento Clone()
    {
      return (Documento)this.MemberwiseClone();
    }
  }
