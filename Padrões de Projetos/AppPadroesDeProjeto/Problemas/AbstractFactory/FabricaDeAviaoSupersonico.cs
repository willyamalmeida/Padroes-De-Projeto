
namespace AppPadroesDeProjeto.Problemas.AbstractFactory
{
    public class FabricaDeAviaoSupersonico : FabricaDeAviao
    {
        private static FabricaDeAviaoSupersonico _instancia;

        private FabricaDeAviaoSupersonico()
        {
        }

        public static FabricaDeAviaoSupersonico Instancia
        {
            get { return _instancia ?? (_instancia = new FabricaDeAviaoSupersonico()); }
        }

        public Asa CrieAsa()
        {
            return new AsaDoAviaoSupersonico();
        }

        public Corpo CrieCorpo()
        {
            return new CorpoDoAviaoSupersonico();
        }

        public Empenagem CrieEmpenagem()
        {
            return new EmpenagemDoAviaoSupersonico();
        }
    }
}
