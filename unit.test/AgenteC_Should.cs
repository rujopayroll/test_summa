using System;
using domain.test.services;
using Xunit.Abstractions;

namespace unit.test
{
    public class AgenteC_Should
    {
        private readonly ITestOutputHelper output;

        public AgenteC_Should(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ValidarMedianaListImpar()
        {
            //list a validar
            List<double> listnumbers = new() { 12, 17, 14, 8, 5 };
            var agente = new AgentC();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(12, respuesta);

        }

        [Fact]
        public void ValidarMedianaListmpar()
        {
            //list a validar
            List<double> listnumbers = new() { 12, 17, 14, 8, 5, 20 };
            var agente = new AgentC();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(13, respuesta);

        }


        [Fact]
        public void ValidarMedianaDecimals()
        {
            //list a validar
            List<double> listnumbers = new() { 0.5, 20.5, 30.6 };
            var agente = new AgentC();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(20.5, respuesta);
        }

        [Fact]
        public void ValidarMedianaDecimalsListImpar()
        {
            //list a validar
            List<double> listnumbers = new() { 0.5, 20.5, 30.6, 18.2 };
            var agente = new AgentC();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(19.35, respuesta);
        }

        [Fact]
        public void ValidarMediaArmonicaListaVacia()
        {
            //list a validar
            List<double> listnumbers = new() { };
            var agente = new AgentC();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(0, respuesta);

        }


        [Fact]
        public void ValidarNoEsMediana()
        {
            //list a validar
            List<double> listnumbers = new() { 10, 20, 30 };
            var agente = new AgentC();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(30, respuesta);


        }


        [Fact]
        public void ValidarEscalera()
        {
            //list a validar
            int number = 10;
            var agente = new AgentC();

            var respuesta = agente.getStaircase(number);
            output.WriteLine(respuesta);

        }

       
    }
}

