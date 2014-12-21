using AppPadroesDeProjeto.Padroes.Abstract_Factory;
using AppPadroesDeProjeto.Padroes.Utilitarios.Enumeradores;
using System;
using System.Collections.Generic;

namespace AppPadroesDeProjeto.Padroes.Utilitarios.Fabricas
{
    public class Factory
    {
        private static Factory _instancia;

        private Factory()
        {
        }

        public static Factory Instancia
        {
            get { return _instancia ?? (_instancia = new Factory()); }
        }

        public AbstractFactory CrieConcreteFactory(TipoDeFabrica tipoDeFabrica)
        {
            var abstractFactorys = new Dictionary<TipoDeFabrica, Type>
            {
                {TipoDeFabrica.UM, typeof(ConcreteFactory1)},
                {TipoDeFabrica.DOIS, typeof(ConcreteFactory2)}
            };

            return (AbstractFactory)Activator.CreateInstance(abstractFactorys[tipoDeFabrica]);
        }
    }
}
