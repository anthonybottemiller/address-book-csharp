using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact> {};
    private string _name;
    private int _id;
    private string _phoneNumber;
    private string _address;

    public Contact(string contactName, string phoneNumber, string address)
    {
      _id = _contacts.Count;
      _name = contactName;
      _phoneNumber = phoneNumber;
      _address = address;
      _contacts.Add(this);
    }

    public int GetId()
    {
      return _id;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetPhone()
    {
      return _phoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public static Contact Find(int id)
    {
      return _contacts[id];
    }
    public static Contact DeleteAll()
    {
      _contacts = {};
    }
  }
}
