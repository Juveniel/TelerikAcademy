const HTTP_HEADER_KEY = "x-auth-key",
      KEY_STORAGE_USERNAME = "username",
      KEY_STORAGE_AUTH_KEY = "authKey";

var dataService = {
    isLoggedIn() {
        return Promise.resolve()
            .then(() => {
                return !!localStorage.getItem("username");
            })
    },

    register(user) {
      return requester.postJSON("/api/users", user);
    },

    login(user) {
        return requester.putJSON("/api/auth", user)
            .then(responseUser => {
                localStorage.setItem("username", responseUser.result.username);
                localStorage.setItem("authKey", responseUser.result.authKey);
            });
    },

    logout() {
        return Promise.resolve()
            .then(() => {
                localStorage.removeItem("username");
                localStorage.removeItem("authKey");
            })
    },

    cookies() {
        return requester.getJSON("/api/cookies");
    },

    addCookie(cookie) {
        let options = {
            headers: {
                [HTTP_HEADER_KEY]: localStorage.getItem(KEY_STORAGE_AUTH_KEY)
            }
        };

        return requester.postJSON("/api/cookies", cookie, options);
    },

    rateCookie(cookieId, type) {
        let options = {
            headers: {
                [HTTP_HEADER_KEY]: localStorage.getItem(KEY_STORAGE_AUTH_KEY)
            }
        };

        return requester.putJSON("/api/cookies/" + cookieId, { type }, options);
    },

    myCookie() {
        let options = {
            headers: {
                [HTTP_HEADER_KEY]: localStorage.getItem(KEY_STORAGE_AUTH_KEY)
            }
        };

        return requester.getJSON("/api/my-cookie", options);
    },

    getUsers() {
        let options = {
            headers: {
                [HTTP_HEADER_KEY]: localStorage.getItem(KEY_STORAGE_AUTH_KEY)
            }
        };

        return requester.getJSON("/api/users", options);
    },

    getCategories() {
        let options = {
            headers: {
                [HTTP_HEADER_KEY]: localStorage.getItem(KEY_STORAGE_AUTH_KEY)
            }
        };

        return requester.getJSON("/api/categories", options);
    }
};