
using AppPadroesDeProjeto.Problemas.AbstractFactory;
using AppPadroesDeProjeto.Problemas.Utilitarios.Enumeradores;

namespace AppPadroesDeProjeto.Problemas.Utilitarios.Fabricas
{
    public class FabricaDeObjeto
    {
        private FabricaDeObjeto()
        {
        }

        public static FabricaDeAviao CrieFabricaDeAviao(TipoDeAviao tipoDeAviao)
        {
            switch (tipoDeAviao)
            {
                case TipoDeAviao.JATO:
                    return FabricaDeAviaoAJato.Instancia;

                case TipoDeAviao.MOTOR:
                    return FabricaDeAviaoAMotor.Instancia;

                case TipoDeAviao.SUPERSONICO:
                    return FabricaDeAviaoSupersonico.Instancia;

                default:
                    return null;
            }
        }
    }
}
