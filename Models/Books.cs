using System;

namespace fisher.bookstore.Models
{

    public class Book
    {
        public int BookId {get; set;}

        public string Title {get; set;}

        public Author Author {get;set;}

        public void SellBook()
        {
            //code to sell book goes here
        }
    }

}