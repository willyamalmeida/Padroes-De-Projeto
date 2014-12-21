
namespace AppPadroesDeProjeto.Padroes.Abstract_Factory
{
    public class ProductA1 : AbstractProductA
    {
        public override string Name { get; set; }

        public override string ToString()
        {
            return string.Concat("AbstractProduct 1: Name ", Name);
        }
    }
}
