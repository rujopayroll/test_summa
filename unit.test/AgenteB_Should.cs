using System;
using domain.test.services;
using Xunit.Abstractions;

namespace unit.test
{
    public class AgenteB_Should
    {
        private readonly ITestOutputHelper output;

        public AgenteB_Should(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ValidarMediaArmonica()
        {
            //list a validar
            List<double> listnumbers = new() { 12, 17, 14, 8, 5 };
            var agente = new AgentB();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(9.283578208295408, respuesta);

        }

        [Fact]
        public void ValidarMediaArmonicaDecimals()
        {
            //list a validar
            List<double> listnumbers = new() { 0.5, 20.5, 30.6 };
            var agente = new AgentB();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(1.4412958566286285, respuesta);
        }

        [Fact]
        public void ValidarMediaArmonicaListaVacia()
        {
            //list a validar
            List<double> listnumbers = new() { };
            var agente = new AgentB();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(0, respuesta);

        }


        [Fact]
        public void ValidarNoEsMediaArmonica()
        {
            //list a validar
            List<double> listnumbers = new() { 10, 20, 30 };
            var agente = new AgentB();

            var respuesta = agente.getMedia(listnumbers);
            Assert.Equal(30, respuesta);
        }

        [Fact]
        public void ValidarEscalera()
        {
            //list a validar
            int number = 30;
            var agente = new AgentB();

            var respuesta = agente.getStaircase(number);
            output.WriteLine(respuesta);

        }
    }

}