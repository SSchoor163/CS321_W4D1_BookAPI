using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public static class BookMappingExtenstions
    {

        public static BookModel ToApiModel(this Book book)
        {
           
            return new BookModel
            {
                Id =book.Id,
                Title = book.Title, 
                OriginalLanguage = book.OriginalLanguage, 
                Genre = book.Genre, 
                PublicationYear = book.PublicationYear, 
                PublisherId = book.PublisherId,
                AuthorId = book.AuthorId, 
                Author =  book.Author != null ? book.Author.LastName + " , " + book.Author.FirstName :null
            };
        }

        public static Book ToDomainModel(this BookModel bookModel)
        {
            // TODO: map the BookModel to a Book domain object
            return new Book
            {
                Id =bookModel.Id,
                Title = bookModel.Title, 
                OriginalLanguage = bookModel.OriginalLanguage, 
                Genre = bookModel.Genre, 
                PublicationYear = bookModel.PublicationYear, 
                PublisherId = bookModel.PublisherId,
                AuthorId = bookModel.AuthorId, 
            };
        }

        public static IEnumerable<BookModel> ToApiModels(this IEnumerable<Book> books)
        {
            return books.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Book> ToDomainModel(this IEnumerable<BookModel> authorModels)
        {
            return authorModels.Select(a => a.ToDomainModel());
        }
    }
}
