function solve() {
	'use strict';

	var library = (function () {
		var books = [],
		    categories = [],
			validator,
			CONSTANTS = {
				TITLE_MIN_LENGTH: 2,
				TITLE_MAX_LENGTH: 100,
				ISBN_LENGTHS: [10, 13]
			};

		validator = {
			validateString: function(value, name){
				name = name || 'Value';

				if(value == undefined){
					throw new Error(name + 'cannot be undefined ');
				}

				if(typeof(value) != 'string'){
					throw new Error(name + ' must be a string');
				}

				if(value.length <= 0){
					throw new Error(name + 'cannot be empty ');
				}
			},
			validateStringLength: function(value, name, min, max){
				name = name || 'Value';

				if(value.length < min || value.length > max){
					throw new Error(name + ' must be between' + min + 'and ' + max);
				}
			},
			validateStringEquals: function(value, name, arrValues){
				name = name || 'Value';

				if(arrValues.indexOf(value) < 0){
					throw new Eror(name + ' has invalid length')
				}
			},
			validateUniqueISBN: function(collection, value){
				var bookToCheck = value || {};

				if(collection.length > 0){
					collection.some(function (book) {
						if(book.isbn === bookToCheck.isbn){
							throw new Error('Invalid ISBN');
						}
					});
				}
			},
			validateUniqueTitle: function(collection, value){
				var bookToCheck = value || {};

				if(collection.length > 0){
					collection.some(function (book) {
						if(book.title === bookToCheck.title){
							throw new Error('Invalid Title');
						}
					});
				}
			},
			validateCategory: function(collection, value){
				var catToCheck = value || '';
				
				return collection.some(function (category) {
					return category === catToCheck
				});

			}
		};

		function listBooks(args) {
			if (args && args.category) {
				return books.filter(function (el) {
					return el.category === args.category;
				});
			}

			if (args && args.author) {
				return books.filter(function (el) {
					return el.author === args.author;
				});
			}

			return books;
		}

		function addBook(book) {
			book.ID = books.length + 1;

			// Title
			validator.validateString(book.title, 'Book title');
			validator.validateUniqueTitle(books, book);
			validator.validateStringLength(
				book.title, 'Book title',
				CONSTANTS.TITLE_MIN_LENGTH,
				CONSTANTS.TITLE_MAX_LENGTH
			);

			// ISBN
			validator.validateString(book.isbn, 'Book ISBN');
			validator.validateUniqueISBN(books, book);
			validator.validateStringEquals(book.isbn.length, 'Book ISBN', CONSTANTS.ISBN_LENGTHS);

			// Author
			validator.validateString(book.author, 'Book Author');

			// Category
			if(!validator.validateCategory(categories, book.category)){
				categories.push(book.category);
			}

			// Validation passed
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
