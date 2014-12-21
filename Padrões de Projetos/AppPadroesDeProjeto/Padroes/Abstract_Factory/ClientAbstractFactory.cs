
using AppPadroesDeProjeto.Padroes.Utilitarios.Enumeradores;
using AppPadroesDeProjeto.Padroes.Utilitarios.Fabricas;

namespace AppPadroesDeProjeto.Padroes.Abstract_Factory
{
    public class ClientAbstractFactory
    {
        public AbstractProductA ProductA { get; private set; }
        public AbstractProductB ProductB { get; private set; }

        public ClientAbstractFactory(TipoDeFabrica tipoDeFabrica)
        {
            var abstractFactory = Factory.Instancia.CrieConcreteFactory(tipoDeFabrica);

            ProductA = abstractFactory.CrieProductA();
            ProductB = abstractFactory.CrieProductB();

            ProductA.Name = "Product A";
            ProductB.Name = "Product B";
        }
    }
}
