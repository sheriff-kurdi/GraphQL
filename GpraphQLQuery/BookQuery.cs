using GraphQL.Models;

namespace GraphQL.GpraphQLQuery
{
    public class BookQuery
    {
        public Book GetBook()=> new Book{Title = null, Author ="Kurdi"};
    }
}