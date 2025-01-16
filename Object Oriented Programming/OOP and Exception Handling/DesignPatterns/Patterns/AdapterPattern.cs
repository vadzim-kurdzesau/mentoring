namespace DesignPatterns.Patterns
{
    // Interface required by the e-commerce platform
    public interface INewInterface
    {
        void ProcessShipping(string address);
    }

    // Outdated legacy shipping provider interface
    //public interface IOldInterface
    //{
    //    void ShipOrder(int orderId, string destination);
    //}

    public class LegacyShippingProvider/* : IOldInterface*/
    {
        public void ShipOrder(int orderId, string destination)
        {
            Console.WriteLine($"Shipping order {orderId} to {destination}");
        }
    }

    public class ShippingAdapter : INewInterface
    {
        private readonly LegacyShippingProvider _legacyShippingProvider;
        private int _orderIdCounter;

        // Adapter receives old interface and uses it's functionality at the same time providing new interface
        public ShippingAdapter(LegacyShippingProvider legacyShippingProvider)
        {
            _legacyShippingProvider = legacyShippingProvider;
            _orderIdCounter = 1;
        }

        public void ProcessShipping(string address)
        {
            _legacyShippingProvider.ShipOrder(_orderIdCounter, address);
            _orderIdCounter++;
        }
    }
}
