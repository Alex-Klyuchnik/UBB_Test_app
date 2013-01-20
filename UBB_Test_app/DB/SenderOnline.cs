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
            int lastId = dbActions.LastId();

            city = dbActions.GetCity(lastId);
            msg = dbActions.AddCity(city);
            string delRes = dbActions.DeleteLocal(lastId, "Cities");
            if (delRes != Resources.Success)
            {
                msg = string.Concat("Deletion from local DB failed: ", delRes);
            }
            return msg;
        }
    }
}
