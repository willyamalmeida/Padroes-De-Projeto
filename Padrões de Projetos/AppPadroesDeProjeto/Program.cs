
using AppPadroesDeProjeto.Padroes.Abstract_Factory;
using AppPadroesDeProjeto.Problemas.Utilitarios.Enumeradores;
using AppPadroesDeProjeto.Problemas.Utilitarios.Fabricas;
using AppPadroesDeProjeto.Padroes.Utilitarios.Enumeradores;
using System;

namespace AppPadroesDeProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ex_001_AbstractFactory();

            Problema_001_AbstractFactory_FabricaDeAvioes();

            Console.ReadKey();
        }

        private static void Problema_001_AbstractFactory_FabricaDeAvioes()
        {
            Imprimir("\n=============================================================");

            var fabricaDeAviao = FabricaDeObjeto.CrieFabricaDeAviao(TipoDeAviao.MOTOR);
            var corpo = fabricaDeAviao.CrieCorpo();
            var asa = fabricaDeAviao.CrieAsa();
            var empenagem = fabricaDeAviao.CrieEmpenagem();

            Imprimir("Tipo de avião a motor\n");
            Imprimir(corpo);
            Imprimir(asa);
            Imprimir(empenagem);

            Imprimir("\n=============================================================");

            fabricaDeAviao = FabricaDeObjeto.CrieFabricaDeAviao(TipoDeAviao.JATO);
            corpo = fabricaDeAviao.CrieCorpo();
            asa = fabricaDeAviao.CrieAsa();
            empenagem = fabricaDeAviao.CrieEmpenagem();

            Imprimir("Tipo de avião a jato\n");
            Imprimir(corpo);
            Imprimir(asa);
            Imprimir(empenagem);

            Imprimir("\n=============================================================");

            fabricaDeAviao = FabricaDeObjeto.CrieFabricaDeAviao(TipoDeAviao.SUPERSONICO);
            corpo = fabricaDeAviao.CrieCorpo();
            asa = fabricaDeAviao.CrieAsa();
            empenagem = fabricaDeAviao.CrieEmpenagem();

            Imprimir("Tipo de avião supersônico\n");
            Imprimir(corpo);
            Imprimir(asa);
            Imprimir(empenagem);

            Imprimir("\n=============================================================");
        }

        private static void Ex_001_AbstractFactory()
        {
            Imprimir("Usando fabrica 1\n");
            var client = new ClientAbstractFactory(TipoDeFabrica.UM);

            Imprimir(client.ProductA);
            Imprimir(client.ProductB);

            Imprimir("\nUsando fabrica 2\n");
            client = new ClientAbstractFactory(TipoDeFabrica.DOIS);

            Imprimir(client.ProductA);
            Imprimir(client.ProductB);
        }

        static void Imprimir(object objeto)
        {
            Console.WriteLine(objeto);
        }
    }
}
