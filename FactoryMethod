public abstract class Aplicacao
{
    private Animal animal;

    Animal criaAnimal();

    void novoAnimal()
    {
        this.animal = this.criaAnimal();
    }
		
    void tipoAnimal()
    {
        this.animal.gato();
    }
}

public abstract class Animal
{
    void gato()
    {
        Console.WriteLine("Animal Tipo Gato");
    }

    void cachorro()
    {
        Console.WriteLine("Animal Tipo Cachorro");
    }

    void peixe()
    {
        Console.WriteLine("Animal Tipo Peixe");
    }
}

public class MinhaAplicacao : Aplicacao
{
    public Animais criaAnimal()
    {
        return new MeuAnimal();
    }
}

public class MeuAnimal : Animal
{

}
