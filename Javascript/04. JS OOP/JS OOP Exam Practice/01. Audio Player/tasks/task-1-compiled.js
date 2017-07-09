'use strict';

function solve() {
    const getId = function () {
        let id = 0;

        return function () {
            id += 1;
            return id;
        };
    }();

    function validateString(value) {
        let len = value.length;

        if (typeof value !== 'string') {
            throw new Error('Not a valid string.');
        }

        if (len < 3 || len > 25) {
            throw new Error('String not in range. Must be between 3 and 25.');
        }
    }

    class Player {
        constructor(name) {
            this.id = getId();
            this.name = name;
            this._playLists = [];

            return this;
        }

        get name() {
            return this._name;
        }

        set name(value) {
            validateString(value);
            this._name = value;
        }

        addPlaylist(playlistToAdd) {
            if (!playlistToAdd instanceof PlayList) {
                throw new Error('Bot a valid type.');
            }

            this._playLists.push(playlistToAdd);

            return this;
        }

        getPlaylistById(id) {
            if (typeof id === 'number') {
                for (let item of this._playLists) {
                    if (item.id === id) {
                        return item;
                    }
                }

                return null;
            }

            throw new Error('Invalid input');
        }

        removePlaylist(playList) {
            let id = playList.id || playList;
            let isRemoved = false;

            this._playLists = this._playLists.filter(item => {
                const isMatch = item.id === id;
                if (isMatch) {
                    isRemoved = true;
                }

                return !isMatch;
            });

            if (!isRemoved) {
                throw new Error('Playlist with id not found');
            }

            return this;
        }

        listPlaylists(page, size) {
            let list = [],
                i;

            page = Number(page);
            size = Number(size);

            if (page < 0) {
                throw new Error('Page cannot be a negative number!');
            }

            if (size <= 0) {
                throw new Error('Size cannot be zero or a negative number!');
            }

            if (this._playLists.length < page * size) {
                throw new Error('Multiplication has a value bigger than the playlists length!');
            }

            for (i = 0; i < size; i += 1) {
                const nextIndex = page * size + i;
                if (this._playLists[nextIndex]) {
                    list.push(this._playLists[nextIndex]);
                } else {
                    break;
                }
            }

            return list;
        }

        contains(playable, playlist) {
            let playableFound = playlist.getPlayableById(playable.id) ? true : false;

            return playableFound;
        }

        search(pattern) {
            let result = [],
                playlist,
                song;

            for (playlist of this._playLists) {
                for (song of this._playLists.playables) {
                    if (song._title.includes(pattern.toLowerCase())) {
                        let matchingPlaylistFound = {
                            name: playlist._name,
                            id: playlist.id
                        };

                        result.push(matchingPlaylistFound);
                        break;
                    }
                }
            }

            return result;
        }
    }

    class PlayList {
        constructor(name) {
            this.id = getId();
            this.name = name;
            this._playables = [];
        }

        get name() {
            return this._name;
        }

        set name(value) {
            validateString(value);
            this._name = value;
        }

        addPlayable(playable) {
            this._playables.push(playable);

            return this;
        }

        getPlayableById(id) {
            if (typeof id === 'number') {
                for (let item of this._playables) {
                    if (item.id === id) {
                        return item;
                    }
                }

                return null;
            }

            throw new Error('Invalid input');
        }

        removePlayable(playable) {
            let id = playable.id || playable;
            let isRemoved = false;

            this._playables = this._playables.filter(item => {
                const isMatch = item.id === id;
                if (isMatch) {
                    isRemoved = true;
                }

                return !isMatch;
            });

            if (!isRemoved) {
                throw new Error('Playlist with id not found');
            }

            return this;
        }

        listPlayables(page, size) {
            let list = [],
                i;

            page = Number(page);
            size = Number(size);

            if (page < 0) {
                throw new Error('Page cannot be a negative number!');
            }

            if (size <= 0) {
                throw new Error('Size cannot be zero or a negative number!');
            }

            if (this._playables.length < page * size) {
                throw new Error('Multiplication has a value bigger than the playlists length!');
            }

            for (i = 0; i < size; i += 1) {
                const nextIndex = page * size + i;
                if (this._playables[nextIndex]) {
                    list.push(this._playables[nextIndex]);
                } else {
                    break;
                }
            }

            return list;
        }
    }

    class Playable {
        constructor(title, author) {
            this.id = getId();
            this.title = title;
            this.author = author;
        }

        get title() {
            return this._title;
        }

        set title(value) {
            validateString(value);
            this._title = value;
        }

        get author() {
            return this._author;
        }

        set author(value) {
            validateString(value);
            this._author = value;
        }

        play() {
            const playString = '${this.id}. ${this.title} - ${this.author}';

            return playString;
        }
    }

    class Audio extends Playable {
        constructor(title, author, length) {
            super(title, author);
            this.length = length;
        }

        get length() {
            return this._length;
        }

        set length(value) {
            if (value.length <= 0) {
                throw new Error('Name must not be empty.');
            }

            this._length = value;
        }

        play() {
            const playString = '${super.play()} - ${this.length}';

            return playString;
        }
    }

    class Video extends Playable {
        constructor(title, author, imdbRating) {
            super(title, author);
            this.imdbRating = imdbRating;
        }

        get imdbRating() {
            return this._imdbRating;
        }

        set imdbRating(value) {
            if (typeof value != 'number') {
                throw new Error('Imdb rating is not a number.');
            }

            if (value.length < 1 || value.length > 5) {
                throw new Error('Imdb rating must be between 1 and 5.');
            }

            this._imdbRating = value;
        }

        play() {
            const playString = '${super.play()} - ${this.imdbRating}';

            return playString;
        }
    }

    const module = {
        getPlayer: function (name) {
            return new Player(name);
        },
        getPlaylist: function (name) {
            return new PlayList(name);
        },
        getAudio: function (title, author, length) {
            return new Audio(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return new Video(title, author, imdbRating);
        }
    };

    return module;
}

module.exports = solve;

//# sourceMappingURL=task-1-compiled.js.map