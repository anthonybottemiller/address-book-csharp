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
      Get["/contact/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact/new"] = _ => {
        var newcontact = new Contact(Request.Form["contact-name"], Request.Form["phone-number"], Request.Form["contact-address"]);
        var contacts = Contact.GetAll();
        return View["new_contact.cshtml", contacts];
      };

    }
  }
}
