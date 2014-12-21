
namespace AppPadroesDeProjeto.Padroes.Abstract_Factory
{
    public class ProductB2 : AbstractProductB
    {
        public override string Name { get; set; }

        public override string ToString()
        {
            return string.Concat("AbstractProduct 2: Name ", Name);
        }
    }
}
