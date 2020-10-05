using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookstore_mvc.Models
{
    public class Bookstoremodel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string MRP { get; set; }
        public author Author { get; set; }
        public category Category { get; set; }
        public publisher Publisher { get; set; }
        public string Authors { get; set; }
        public string Categorys { get; set; }
        public string Publishers { get; set; }
    }

    public enum author
    {
        Select,
        Bhagat,
        MujahidKhan,
        GatiMeher,
        Roshan,
    }

    public enum category
    {
        Select,
        ComputerScience,
        English,
        Comics,
        Religional,
    }
    public enum publisher
    {
        Select,
        DivyaJain,
        Simon,
        AshishGajbiye,
        Howard,
    }
}