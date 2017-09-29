using System.Collections.Generic;

namespace OlderUnitTestsConsole
{
    public interface IPaymentGateway
    {
         decimal GetTotal(List<string> items);
    }

    //Clase que uso para tests unitarios
    public class MockGateway : IPaymentGateway
    {
        public decimal GetTotal(List<string> items)
        {
            return 0.0m;
        }
    }

    //Clase que uso realmente para la lógica
    public class PaymentGateway:IPaymentGateway
    {


        public decimal GetTotal(List<string> items)
        {
            //Autenticación
            //Datos de la cuenta
            //Procesar tarjeta de crédito
            //Otras cosas que NO quiero hacer en un unit test...
            return 5.5m;
        }
    }
}