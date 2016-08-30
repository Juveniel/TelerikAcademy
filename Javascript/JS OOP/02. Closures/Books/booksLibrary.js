function solve() {
    'use strict';

    var library = (function () {
        var books = [],
            categories = [];

        function listBooks() {
            return books;
        }

        function addBook(book) {
            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    } ());
    
    return library;
}
module.exports = solve;