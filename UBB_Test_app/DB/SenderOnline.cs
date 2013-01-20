using UBB_Test_app.Entities;
using UBB_Test_app.Properties;

namespace UBB_Test_app.DB
{
    class SenderOnline
    {
        public string SendCity()
        {
            City city = new City();
            DBActions dbActions = new DBActions();
            string msg = "";
            string table = "Cities";
            int lastId = dbActions.LastId(table);

            city = dbActions.GetCity(lastId);
            msg = dbActions.AddCity(city);
            string delRes = dbActions.DeleteLocal(lastId, table);
            if (delRes != Resources.Success)
            {
                msg = string.Concat("Deletion from local DB failed: ", delRes);
            }
            return msg;
        }

        public string SendPerson()
        {
            Person person = new Person();
            DBActions dbActions = new DBActions();
            string msg = "";
            string table = "People";
            int lastId = dbActions.LastId(table);

            person = dbActions.GetPerson(lastId);
            msg = dbActions.PersonAdd(person);
            string delRes = dbActions.DeleteLocal(lastId, table);
            if (delRes != Resources.Success)
            {
                msg = string.Concat("Deletion from local DB failed: ", delRes);
            }
            return msg;
        }
    }
}
