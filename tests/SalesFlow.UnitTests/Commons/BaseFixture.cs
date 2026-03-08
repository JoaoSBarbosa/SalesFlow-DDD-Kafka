using Bogus;

namespace SalesFlow.UnitTests.Commons;

public abstract class BaseFixture
{
    public Faker Faker { get; } = new("pt_BR");
}