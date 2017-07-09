let requester = {
    get(url,  options = {}) {
        let promise = new Promise((resolve, reject) => {
            $.ajax({
                url,
                options,
                method: "GET",
                success(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });
        return promise;
    },
    putJSON(url, body, options = {}) {
        let promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};
            $.ajax({
                url,
                headers,
                method: "PUT",
                contentType: "application/json",
                data: JSON.stringify(body),
                success(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });
        return promise;
    },
    postJSON(url, body, options = {}) {
        let promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};

            $.ajax({
                url,
                headers,
                method: "POST",
                contentType: "application/json",
                data: JSON.stringify(body),
                success(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });
        return promise;
    },
    getJSON(url, options = {}) {
        let promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};
            $.ajax({
                url,
                headers,
                method: "GET",
                contentType: "application/json",
                success(response) {
                    resolve(response);
                },
                error(response) {
                    reject(response);
                }
            });
        });
        return promise;
    }
};