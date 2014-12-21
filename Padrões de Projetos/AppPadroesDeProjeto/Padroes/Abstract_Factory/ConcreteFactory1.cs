
using AppPadroesDeProjeto.Padroes.Utilitarios.Fabricas;

namespace AppPadroesDeProjeto.Padroes.Abstract_Factory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public AbstractProductA CrieProductA()
        {
            return FactoryProduct.Instancia.CrieProductA1();
        }

        public AbstractProductB CrieProductB()
        {
            return FactoryProduct.Instancia.CrieProductB1();
        }
    }
}
