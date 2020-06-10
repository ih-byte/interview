using CodingTest.Model;

namespace CodingTest.BusinessService
{
    public interface IPayment
    {
        double CalculateAmount(ProductItem product);
    }
}
