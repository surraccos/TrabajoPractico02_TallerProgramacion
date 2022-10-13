using NUnit.Framework.Internal;
using System.Security.Cryptography;

namespace ClasesEj01.test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class PuntoTests
    {
      
        [Test]
        public void DistanciaEntreDiferentes()
        {
            //Arrange
            var punto = new Punto(5,2);
            var punto2 = new Punto(3, 8);

            //Act
            var result = punto.CalcularDistanciaDesde(punto2);

            //Assert
            Assert.AreEqual(6.3245, result,0.001);
        }
        [Test]
        public void DistanciaEntreiguales()
        {
            //Arrange
            var punto = new Punto(5, 2);
            var punto2 = new Punto(5, 2);

            //Act
            var result = punto.CalcularDistanciaDesde(punto2);

            //Assert
            Assert.AreEqual(0, result, 0.001);
        }
    }
}