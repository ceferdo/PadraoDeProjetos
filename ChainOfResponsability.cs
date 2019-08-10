public enum IDJogadores {
    jogador1, jogador2, jogador3, jogador4 
}

public abstract class PokerChain {
 
    protected PokerChain next;
    protected IDJogadores identificadorDeJogadores;
 
    public PokerChain(IDJogadores id) {
        next = null;
        identificadorDeJogadores = id;
    }
 
    public void setNext(PokerChain forma) {
        if (next == null) {
            next = forma;
        } else {
            next.setNext(forma);
        }
    }
}

public void entrarNaMesa(IDJogadores id) throws Exception {
    if (podeEntrarNaMesa(id)) {
        entraNaMesa();
    } else {
        if (next == null) {
            throw new Exception("Jogador fora da Mesa");
        }
        next.entrarNaMesa(id);
    }
}
 
private boolean podeEntrarNaMesa(IDJogadores id) {
    if (identificadorDeJogadores == id) {
        return true;
    }
    return false;
}
 
protected abstract void entraNaMesa();

public class Jogador1 extends PokerChain {
 
    public Jogador1() {
        super(IDJogadores.jogador1);
    }
 
    @Override
    protected void entraNaMesa() {
        System.out.println("Jogador 1 entrou na mesa");
    }
}

public static void main(String[] args) {
    PokerChain jogadores = new Jogador1();
    jogadores.setNext(new Jogador2());
    jogadores.setNext(new Jogador3());
    jogadores.setNext(new Jogador4());
     
    try {
        jogadores.efetuarPagamento(IDJogadores.jogador2);
        jogadores.efetuarPagamento(IDJogadores.jogador3);
        jogadores.efetuarPagamento(IDJogadores.jogador4);
    } catch (Exception e) {
        e.printStackTrace();
    }
}
