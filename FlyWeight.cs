public class Arquivo {
    protected String nomeDoArquivo;
 
    public Arquivo(String arquivo) {
        nomeDoArquivo = arquivo;
    }
 
    public void movimentarArquivo() {
        System.out.println(nomeDoArquivo + " movimenado!");
    }
}

public class Ponto {
    public int x, y;
 
    public Ponto(int x, int y) {
        this.x = x;
        this.y = y;
    }
}

public abstract class SpriteFlyweight {
    public abstract void movimentarArquivo(Ponto ponto);
}

public class Sprite extends SpriteFlyweight {
    protected Arquivo arquivo;
 
    public Sprite(String nomeDoArquivo) {
        arquivo = new Arquivo(nomeDoArquivo);
    }
 
    @Override
    public void movimentarArquivo(Ponto ponto) {
        arquivo.movimentarArquivo();
        System.out.println("No ponto (" + ponto.x + "," + ponto.y + ")!");
    }
}

public class FlyweightFactory {
 
    protected ArrayList<SpriteFlyweight> flyweights;
 
    public enum Sprites {
        ARQUIVO, ARQUIVO_2, ARQUIVO_3, ARQUIVO_4, ARQUIVO_5, ARQUIVO_6
    }
 
    public FlyweightFactory() {
        flyweights = new ArrayList<SpriteFlyweight>();
        flyweights.add(new Sprite("arquivo"));
        flyweights.add(new Sprite("arquivo_2"));
        flyweights.add(new Sprite("arquivo_3"));
        flyweights.add(new Sprite("arquivo_4"));
        flyweights.add(new Sprite("arquivo_5"));
        flyweights.add(new Sprite("arquivo_6"));
    }
 
    public SpriteFlyweight getFlyweight(Sprites arquivo) {
        switch (arquivo) {
        case AQUIVO:
            return flyweights.get(0);
        case ARQUIVO_2:
            return flyweights.get(1);
        case ARQUIVO_3:
            return flyweights.get(2);
        case ARQUIVO_4:
            return flyweights.get(3);
        case ARQUIVO_5:
            return flyweights.get(4);
        default:
            return flyweights.get(5);
        }
    }
}

public static void main(String[] args) {
    FlyweightFactory factory = new FlyweightFactory();
 
    factory.getFlyweight(Sprites.ARQUIVO_2).movimentarArquivo(new Ponto(0, 0));
 
    factory.getFlyweight(Sprites.ARQUIVO).movimentarArquivo(new Ponto(10, 10));
 
    factory.getFlyweight(Sprites.ARQUIVO_4).movimentarArquivo(
            new Ponto(100, 10));
    factory.getFlyweight(Sprites.ARQUIVO_3).movimentarArquivo(
            new Ponto(120, 10));
    factory.getFlyweight(Sprites.ARQUIVO_6).movimentarArquivo(
            new Ponto(140, 10));
}
