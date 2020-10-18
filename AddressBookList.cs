// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookSystemUsingCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// CONTAINS NUMEROUS ADDRESS BOOKS
    /// </summary>
    class AddressBookList
    {
        /// <summary>
        /// STORES THE NUMEROUS ADDRESS BOOKS WITH KEY AS THE ADDDRESS BOOK NAME
        /// </summary>
        public Dictionary<string, AddressBook> addressBookListDictionary = new Dictionary<string, AddressBook>();

        /// <summary>
        /// UC 6 : ADDS A NEW ADDRESS BOOK WITH UNIQUE NAME TO THE SYSTEM
        /// </summary>
        public void AddNewAddressBook()
        {
            Console.WriteLine("Enter the name of address book:");
            string addressBookName = Console.ReadLine();
            AddressBook addressBook = new AddressBook(addressBookName);
            /// HANDLES THE EXCEPTION WHEN THE USER TRIES TO ENTER DUPLICATE ADDRESS BOOK NAME
            try
            {
                addressBookListDictionary.Add(addressBookName, addressBook);
                Console.WriteLine("\nAddress Book " + addressBookName + " added successfully");
                Console.WriteLine("Updated Address Book List:");
                foreach (var kvp in addressBookListDictionary)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Address Book {0} already exists, please access it or add a new address book with different name!", addressBookName);
            }
        }

        /// <summary>
        /// CHECKS FOR AN EXISTING ADDRESS BOOK IN THE SYSTEM
        /// IF FOUND RETURNS ITS NAME ELSE RETURNS NULL VALUE
        /// </summary>
        /// <returns>addressBookName</returns>
        public string ExistingAddressBook()
        {
            Console.WriteLine("Enter the Address Book name");
            string addressBookName = Console.ReadLine();
            string result = "";
            bool flag = true;
            foreach (var kvp in addressBookListDictionary)
            {
                if (kvp.Key == addressBookName)
                {
                    result = addressBookName;
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("No Address Book with name " + addressBookName + " found\nPlease create a new address book");
            }
            return result;
        }
    }
}