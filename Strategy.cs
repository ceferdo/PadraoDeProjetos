public double percorrerVetor() {
        switch (tipo) {
        case TIPO1:
            if (salarioBase >= 2000) {
                return salarioBase * 0.85;
            } else {
                return salarioBase * 0.9;
            }
        case TIPO2:
            if (salarioBase >= 3500) {
                return salarioBase * 0.8;
            } else {
                return salarioBase * 0.85;
            }
        case TIPO3:
            if (salarioBase >= 2000) {
                return salarioBase * 0.85;
            } else {
                return salarioBase * 0.9;
            }
        default:
            throw new RuntimeException("Tipo não encontrado :/");
        }
    }

    interface CalculaImposto {
    double calculaSalarioComImposto(Funcionario umFuncionario);
}

public class CalculoImpostoQuinzeOuDez implements CalculaImposto {
    @Override
    public double calculaSalarioComImposto(Funcionario umFuncionario) {
        if (umFuncionario.getSalarioBase() > 2000) {
            return umFuncionario.getSalarioBase() * 0.85;
        }
        return umFuncionario.getSalarioBase() * 0.9;
    }
}

public Funcionario(int tipo, double salarioBase) {
        this.salarioBase = salarioBase;
        switch (tipo) {
        case TIPOVETOR1:
            estrategiaDeCalculo = new CalculoImpostoQuinzeOuDez();
            tipo = TIPOVETOR1;
            break;
        case DBA:
            estrategiaDeCalculo = new CalculoImpostoQuinzeOuDez();
            tipo = DBA;
            break;
        case TIPO2:
            estrategiaDeCalculo = new CalculoImpostoVinteOuQuinze();
            tipo = TIPO2;
            break;
        default:
            throw new RuntimeException("Tipo não encontrado :/");
        }
    }

    public double percorrerVetor() {
    return estrategiaDeCalculo.calculaSalarioComImposto(this);
}

