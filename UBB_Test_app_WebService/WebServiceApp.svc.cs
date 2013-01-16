using System;
using ServerServiceApp.DB;

namespace ServerServiceApp
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "WebServiceApp" в коде, SVC-файле и файле конфигурации.
    public class WebServiceApp : IWebServiceApp
    {
        public string MaxPopulation()
        {
            DBEdit dbedit = new DBEdit();
            return dbedit.MaxPop();
        }
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
