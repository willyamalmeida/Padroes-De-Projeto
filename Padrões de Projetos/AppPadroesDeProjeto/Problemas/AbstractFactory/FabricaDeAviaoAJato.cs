
namespace AppPadroesDeProjeto.Problemas.AbstractFactory
{
    public class FabricaDeAviaoAJato : FabricaDeAviao
    {
        private static FabricaDeAviaoAJato _instancia;

        private FabricaDeAviaoAJato()
        {
        }

        public static FabricaDeAviaoAJato Instancia
        {
            get { return _instancia ?? (_instancia = new FabricaDeAviaoAJato()); }
        }

        public Asa CrieAsa()
        {
            return new AsaDoAviaoAJato();
        }

        public Corpo CrieCorpo()
        {
            return new CorpoDoAviaoAJato();
        }

        public Empenagem CrieEmpenagem()
        {
            return new EmpenagemDoAviaoAJato();
        }
    }
}
