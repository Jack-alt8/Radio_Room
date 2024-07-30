

using Radio_Room.UI.Components.Pages;

namespace Radio_Room.UI
{
    public class ApiTestClass
    {
        string candidate = new Home.DataObject();
        public bool IsWorking(string candidate)
        {
            if (candidate == "")
            {
                {
                    return false;
                }
                throw new NotImplementedException("Not fully implemented.");
            }
            else
            {
                return true;
            }
        }
    }
}
