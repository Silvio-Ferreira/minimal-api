using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedadesVeiculos()
    {
        //Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "Uno";
        veiculo.Marca = "Fiat";
        veiculo.Ano = 2010;

        //Assert
       Assert.AreEqual(1,veiculo.Id);
       Assert.AreEqual("Uno",veiculo.Nome);
       Assert.AreEqual("Fiat",veiculo.Marca);
       Assert.AreEqual(2010,veiculo.Ano);
    }
}