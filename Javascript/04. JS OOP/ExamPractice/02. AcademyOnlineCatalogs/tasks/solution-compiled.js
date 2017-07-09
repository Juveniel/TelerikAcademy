'use strict';

function solve() {

    const getId = function () {
        let id = 0;

        return function () {
            id += 1;
            return id;
        };
    }();

    const validator = {
        validateString: function (value, name) {
            name = name || 'Value';

            if (value == undefined) {
                throw new Error(name + 'cannot be undefined ');
            }

            if (typeof value != 'string') {
                throw new Error(name + ' must be a string');
            }

            if (value.length <= 0) {
                throw new Error(name + 'cannot be empty ');
            }
        },
        validateStringLength: function (value, name, min, max) {
            name = name || 'Value';

            if (value.length < min || value.length > max) {
                throw new Error(name + ' must be between' + min + 'and ' + max);
            }
        },
        validateIsbn: function (value) {
            if (typeof value != 'string') {
                throw new Error('ISBN must be a string');
            }

            if (value.length !== 10 && value.length !== 13) {
                throw new Error('ISBN must be with 10 or 13 digits');
            }

            if (!value.match("[0-9]+")) {
                throw new Error('ISBN must contain digits only');
            }
        },
        validateNumber: function (value, name, min = 0, max = Number.MAX_VALUE) {
            if (typeof value !== 'number') {
                throw new Error(name + ' is not a number');
            }

            if (value < min || value > max) {
                throw new Error(name + ' must be between' + min + 'and ' + max);
            }
        },
        validateItem: function (items) {
            if (items.length === 0) {
                throw new Error('No elements provided');
            }

            items.forEach(function (item) {
                if (!item instanceof Item) {
                    throw new Error('Invalid item provided');
                }
            });
        }
    };

    const MIN_ITEM_NAME_LENGHT = 2,
          MAX_ITEM_NAME_LENGHT = 40;

    const MIN_GENRE_LENGTH = 2,
          MAX_GENRE_LENGTH = 20;

    const MIN_RATING = 1,
          MAX_RATING = 5;

    class Item {
        constructor(description, name) {
            this.id = getId();
            this.description = description;
            this.name = name;
        }

        get description() {
            return this._description;
        }

        set description(value) {
            validator.validateString(value, 'Description');
            this._description = value;
        }

        get name() {
            return this._name;
        }

        set name(value) {
            validator.validateString(value, 'name');
            validator.validateStringLength(value, 'Name', MIN_ITEM_NAME_LENGHT, MAX_ITEM_NAME_LENGHT);
            this._name = value;
        }
    }

    class Book extends Item {
        constructor(description, name, isbn, genre) {
            super(description, name);
            this.isbn = isbn;
            this.genre = genre;
        }

        get isbn() {
            return this._isbn;
        }

        set isbn(value) {
            validator.validateIsbn(value);
            this._isbn = value;
        }

        get genre() {
            return this._genre;
        }

        set genre(value) {
            validator.validateString(value, 'Genre');
            validator.validateStringLength(value, 'Genre', MIN_GENRE_LENGTH, MAX_GENRE_LENGTH);
            this._genre = value;
        }
    }

    class Media extends Item {
        constructor(description, name, duration, rating) {
            super(description, name);
            this.duration = duration;
            this.rating = rating;
        }

        get duration() {
            return this._duration;
        }

        set duration(value) {
            validator.validateNumber(value, 'Duration', 1);
            this._duration = value;
        }

        get rating() {
            return this._rating;
        }

        set rating(value) {
            validator.validateNumber(value, 'Rating', MIN_RATING, MAX_RATING);
            this._rating = value;
        }
    }

    class Catalog {
        constructor(name) {
            this.id = getId();
            this.name = name;
            this.items = [];
        }

        get name() {
            return this._name;
        }

        set name(value) {
            validator.validateStringLength(value, 'Catalog name', MIN_ITEM_NAME_LENGHT, MAX_ITEM_NAME_LENGHT);
            this._name = value;
        }

        add(...items) {
            if (Array.isArray(items[0])) {
                items = items[0];
            }

            if (items.length === 0) {
                throw 'No items are added';
            }

            this.items.push(...items);

            return this;
        }

        find(id) {
            //validator.validateNumber(id);

            if (typeof id === 'number') {
                for (let item of this.items) {
                    if (item.id === id) {
                        return item;
                    }
                }

                return null;
            }

            if (id !== null && typeof id === 'object') {
                return this.items.filter(function (item) {
                    return Object.keys(id).every(function (prop) {
                        return id[prop] === item[prop];
                    });
                });
            }

            throw 'Invalid options or id';
        }

        search(pattern) {
            validator.validateString(pattern, 'Search pattern');

            return this.items.filter(function (item) {
                return item.name.indexOf(pattern) >= 0 || item.description.indexOf(pattern) > 0;
            });
        }
    }

    class BookCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...books) {
            if (Array.isArray(books[0])) {
                books = books[0];
            }

            books.forEach(function (x) {
                if (!(x instanceof Book)) {
                    throw 'Must add only books';
                }
            });

            return super.add(...books);
        }

        getGenres() {
            let result = [];

            this.items.forEach(book => {
                let genre = book.genre.toLowerCase();

                if (result.indexOf(genre) < 0) {
                    result.push(genre);
                }
            });

            return result;
        }

        find(otpions) {
            return super.find(otpions);
        }
    }

    class MediaCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...medias) {
            if (Array.isArray(medias[0])) {
                medias = medias[0];
            }

            medias.forEach(function (x) {
                if (!(x instanceof Media)) {
                    throw 'Must add only medias';
                }
            });

            return super.add(...medias);
        }

        getTop(count) {
            let result = [],
                itmesSorted = this.items.sort((a, b) => a.rating < b.rating);

            validator.validateNumber(count, 'count', 1);

            for (let i = 0; i < count; i += 1) {
                if (itmesSorted[i]) {
                    result.push({
                        id: itmesSorted[i].id,
                        name: itmesSorted[i].name
                    });
                } else {
                    break;
                }
            }

            return result;
        }

        getSortedByDuration() {
            return this.items.sort((a, b) => {
                if (a.duration === b.duration) {
                    return a.id < b.id;
                }

                return a.duration > b.duration;
            });
        }
    }

    const module = {
        getBook(name, isbn, genre, description) {
            return new Book(description, name, isbn, genre);
        },
        getMedia(name, rating, duration, description) {
            return new Media(description, name, duration, rating);
        },
        getBookCatalog(name) {
            return new BookCatalog(name);
        },
        getMediaCatalog(name) {
            return new MediaCatalog(name);
        }
    };

    return module;
}

module.exports = solve;

//# sourceMappingURL=solution-compiled.js.map