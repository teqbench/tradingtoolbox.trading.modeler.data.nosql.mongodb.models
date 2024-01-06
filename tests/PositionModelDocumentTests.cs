namespace TradingToolbox.Trading.Modeler.Data.NoSql.MongoDB.Models.Tests;

[TestClass]
public class PositionModelDocumentTests
{
    [TestMethod]
    public void TestConstructor()
    {
        PositionModelDocument document = new PositionModelDocument();

        Assert.IsNull(document.Id);
        Assert.IsNull(document.Name);
        Assert.AreEqual(document.InitialValue, 0);
        Assert.AreEqual(document.PricePerShare, 0);

        Assert.AreEqual(document.AverageNumberOfPositionsPerDay, 0);
        Assert.AreEqual(document.AverageNumberOfLotsPerPosition, 0);
        Assert.AreEqual(document.AverageNumberOfTradingDaysPerWeek, 0);

        Assert.AreEqual(document.EstimatedSuccessRate, 0);
        Assert.AreEqual(document.TargetGain, 0);
        Assert.AreEqual(document.FederalTaxRate, 0);
        Assert.AreEqual(document.StateTaxRate, 0);
        Assert.AreEqual(document.Expenses, 0);
        Assert.AreEqual(document.EstimatedFeePerTransaction, 0);

        Assert.AreEqual(document.ListPosition, 0);

        document = new PositionModelDocument("64c0a0ab8e22874a66eadb4c");
        Assert.AreEqual(document.Id, "64c0a0ab8e22874a66eadb4c");

        Assert.IsNull(document.Name);
        Assert.AreEqual(document.InitialValue, 0);
        Assert.AreEqual(document.PricePerShare, 0);

        Assert.AreEqual(document.AverageNumberOfPositionsPerDay, 0);
        Assert.AreEqual(document.AverageNumberOfLotsPerPosition, 0);
        Assert.AreEqual(document.AverageNumberOfTradingDaysPerWeek, 0);

        Assert.AreEqual(document.EstimatedSuccessRate, 0);
        Assert.AreEqual(document.TargetGain, 0);
        Assert.AreEqual(document.FederalTaxRate, 0);
        Assert.AreEqual(document.StateTaxRate, 0);
        Assert.AreEqual(document.Expenses, 0);
        Assert.AreEqual(document.EstimatedFeePerTransaction, 0);

        Assert.AreEqual(document.ListPosition, 0);
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_Null_ExpectedException()
    {
        PositionModelDocument document = new PositionModelDocument(null);
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_EmptyString_ExpectedException()
    {
        PositionModelDocument document = new PositionModelDocument(string.Empty);
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_InvalidId_ExpectedException()
    {
        PositionModelDocument document = new PositionModelDocument("bad id");
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestConstructor_WhiteSpace_ExpectedException()
    {
        PositionModelDocument document = new PositionModelDocument("   ");
    }

    [TestMethod]
    public void TestProperties()
    {
        PositionModelDocument document = new PositionModelDocument();

        document.Id = "64c0a0ab8e22874a66eadb4c";
        Assert.AreEqual(document.Id, "64c0a0ab8e22874a66eadb4c");

        document.Name = "A name";
        Assert.AreEqual(document.Name, "A name");

        document.InitialValue = 100;
        Assert.AreEqual(document.InitialValue, 100);

        document.PricePerShare = 200;
        Assert.AreEqual(document.PricePerShare, 200);

        document.AverageNumberOfPositionsPerDay = 10;
        Assert.AreEqual(document.AverageNumberOfPositionsPerDay, 10);

        document.AverageNumberOfLotsPerPosition = 11;
        Assert.AreEqual(document.AverageNumberOfLotsPerPosition, 11);

        document.AverageNumberOfTradingDaysPerWeek = 4;
        Assert.AreEqual(document.AverageNumberOfTradingDaysPerWeek, 4);

        document.EstimatedSuccessRate = 0.9M;
        Assert.AreEqual(document.EstimatedSuccessRate, 0.9M);

        document.TargetGain = 0.1M;
        Assert.AreEqual(document.TargetGain, 0.1M);

        document.FederalTaxRate = 0.37M;
        Assert.AreEqual(document.FederalTaxRate, 0.37M);

        document.StateTaxRate = 0.069M;
        Assert.AreEqual(document.StateTaxRate, 0.069M);

        document.Expenses = 10000.0M;
        Assert.AreEqual(document.Expenses, 10000.0M);

        document.EstimatedFeePerTransaction = 3.95M;
        Assert.AreEqual(document.EstimatedFeePerTransaction, 3.95M);

        document.ListPosition = 1;
        Assert.AreEqual(document.ListPosition, 1);
    }
}
