using System;
using Xunit;
using domain.test.services;
using Xunit.Abstractions;

namespace unit.test
{
    public class AgenteA_Should
    {
        private readonly ITestOutputHelper output;

        public AgenteA_Should(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ValidarMediaAritmetica()
        {
            //list a validar
            List<double> listnumbers = new() { 10, 20, 30 };
            var agenteA = new AgentA();

            var respuesta = agenteA.getMedia(listnumbers);
            Assert.Equal(20, respuesta);
           
        }

        [Fact]
        public void ValidarMediaAritmeticaDecimals()
        {
            //list a validar
            List<double> listnumbers = new() { 0.5 , 20.5, 30.6 };
            var agenteA = new AgentA();

            var respuesta = agenteA.getMedia(listnumbers);
            Assert.Equal(17.3, respuesta);
        }

        [Fact]
        public void ValidarMediaAritmeticaListaVacia()
        {
            //list a validar
            List<double> listnumbers = new() { };
            var agenteA = new AgentA();

            var respuesta = agenteA.getMedia(listnumbers);
            Assert.Equal(0, respuesta);

        }


        [Fact]
        public void ValidarNoEsMediaAritmetica()
        {
            //list a validar
            List<double> listnumbers = new() { 10, 20, 30 };
            var agenteA = new AgentA();

            var respuesta = agenteA.getMedia(listnumbers);
            Assert.Equal(30, respuesta);

        }

        [Fact]
        public void ValidarEscalera()
        {
            //list a validar
            int number= 30;
            var agenteA = new AgentA();

            var respuesta = agenteA.getStaircase(number);
            output.WriteLine(respuesta);

        }

     
    }


}

