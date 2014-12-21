
namespace AppPadroesDeProjeto.Problemas.AbstractFactory
{
    public class FabricaDeAviaoAMotor : FabricaDeAviao
    {
        private static FabricaDeAviaoAMotor _instancia;

        private FabricaDeAviaoAMotor()
        {
        }

        public static FabricaDeAviaoAMotor Instancia
        {
            get { return _instancia ?? (_instancia = new FabricaDeAviaoAMotor()); }
        }

        public Asa CrieAsa()
        {
            return new AsaDoAviaoAMotor();
        }

        public Corpo CrieCorpo()
        {
            return new CorpoDoAviaoAMotor();
        }

        public Empenagem CrieEmpenagem()
        {
            return new EmpenagemDoAviaoAMotor();
        }
    }
}
