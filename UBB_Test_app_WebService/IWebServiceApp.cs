using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServerServiceApp
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IWebServiceApp" в коде и файле конфигурации.
    [ServiceContract]
    public interface IWebServiceApp
    {

        [OperationContract]
        string MaxPopulation();
        
        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType 
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        
        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
