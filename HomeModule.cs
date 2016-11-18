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
      Get["/contact/{id}"] = _ => {
        var searchedContact = Contacts.Find(id);
        return View{"contact.cshtml", searchedContact};
      };
      Post["/contact/new"] = _ => {
        var newContact = new Contact(Request.Form["contact-name"], Request.Form["phone-number"], Request.Form["contact-address"]);
        return View["new_contact.cshtml", newContact];
      };

    }
  }
}
