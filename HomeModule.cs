using Nancy;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var contacts = Contact.GetAll();
        return View["index.cshtml", contacts];
      };
    }
  }
}
