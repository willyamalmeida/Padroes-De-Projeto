
namespace AppPadroesDeProjeto.Problemas.AbstractFactory
{
    public interface FabricaDeAviao
    {
        Asa CrieAsa();
        Corpo CrieCorpo();
        Empenagem CrieEmpenagem();
    }
}
