
using AppPadroesDeProjeto.Padroes.Utilitarios.Fabricas;

namespace AppPadroesDeProjeto.Padroes.Abstract_Factory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public AbstractProductA CrieProductA()
        {
            return FactoryProduct.Instancia.CrieProductA2();
        }

        public AbstractProductB CrieProductB()
        {
            return FactoryProduct.Instancia.CrieProductB2();
        }
    }
}
