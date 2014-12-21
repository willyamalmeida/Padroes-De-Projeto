
using AppPadroesDeProjeto.Padroes.Abstract_Factory;

namespace AppPadroesDeProjeto.Padroes.Utilitarios.Fabricas
{
    public class FactoryProduct
    {
        private static FactoryProduct _instancia;

        private FactoryProduct()
        {
        }

        public static FactoryProduct Instancia
        {
            get { return _instancia ?? (_instancia = new FactoryProduct()); }
        }

        public ProductA1 CrieProductA1()
        {
            return new ProductA1();
        }

        public ProductA2 CrieProductA2()
        {
            return new ProductA2();
        }

        public ProductB1 CrieProductB1()
        {
            return new ProductB1();
        }

        public ProductB2 CrieProductB2()
        {
            return new ProductB2();
        }
    }
}
