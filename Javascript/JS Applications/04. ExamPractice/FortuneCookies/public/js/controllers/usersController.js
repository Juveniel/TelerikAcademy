let usersController = {
    get(dataService, templates) {
        return {
            list() {
                let users;
                dataService.isLoggedIn()
                    .then(isLoggedIn => {
                        if(!isLoggedIn) {
                            window.location = "#/login";
                            return;
                        }

                        dataService.getUsers()
                            .then((usersResponse) => {
                                users = usersResponse;

                                return templates.get("users");
                            })
                            .then((templateHtml) => {
                                let templateFunc = handlebars.compile(templateHtml);
                                let html = templateFunc(users);
                                $("#container").html(html);

                                /*$(".btn-like-dislike").on("click", function(ev) {
                                    let type = $(this).attr("data-type");
                                    let cookieId = $(this).parents("li").attr("data-id");
                                    console.log(type);
                                    console.log(cookieId);
                                    dataService.rateCookie(cookieId, type)
                                        .then();

                                });*/
                            })
                            .catch((error) => {
                                toastr.error(error.responseText);
                            });
                    });
            },

            login() {
                dataService.isLoggedIn()
                    .then(isLoggedIn => {
                        if (isLoggedIn) {
                            window.location = "#/home";
                            return;
                        }

                        templates.get("login")
                            .then((templateHtml) => {
                                let templateFunc = handlebars.compile(templateHtml);
                                let html = templateFunc();
                                $("#container").html(html);

                                $("#btn-login").on("click", (ev) => {
                                    let user = {
                                        username: $("#tb-username").val(),
                                        passHash: $("#tb-password").val()
                                    };

                                    dataService.login(user)
                                        .then((respUser) => {
                                            toastr.success('Logging you in...');
                                            $(document.body).addClass("logged-in");
                                            document.location = "#/home";
                                        })
                                        .catch((error) => {
                                            toastr.error(error.responseText);
                                        });
                                });

                                $("#btn-register").on("click", () => {
                                    let user = {
                                        username: $("#tb-username").val(),
                                        passHash: $("#tb-password").val()
                                    };

                                    const usernameLength = user.username.length;
                                    if (usernameLength <= 6 || usernameLength >= 30) {
                                        toastr.error('Incorret username length.', 'Username should be between 6 and 30 characters long.');
                                        return new Promise((resolve, reject) => {
                                            resolve();
                                        });
                                    }

                                    dataService.register(user)
                                        .then(() => {
                                            dataService.login(user);
                                        })
                                        .then(() => {
                                            toastr.success('Successfully registered! Logging you in...');
                                            $(document.body).addClass("logged-in");
                                            document.location = "#/home";
                                        })
                                        .catch((error) => {
                                            toastr.error(error.responseText);
                                        });
                                });

                            });
                    });
            },

            logout() {
                dataService.logout()
                    .then(() => {
                        $(document.body).removeClass("logged-in");
                        document.location = "#/home";
                    });
            },

            shareCookie() {
                templates.get("cookie-add")
                    .then((templateHtml) => {
                        let templateFunc = handlebars.compile(templateHtml);
                        let html = templateFunc();

                        $("#container").html(html);

                        $("#btn-add").on("click", () => {
                            var cookie = {
                                text: $("#tb-text").val(),
                                category: $("#tb-category").val(),
                                img: $("#tb-img-url").val()
                            };

                            dataService.addCookie(cookie)
                                .then(() => {
                                    window.location = "#/home";
                                });
                        });
                    });
            },

            myCookie() {
                dataService.isLoggedIn()
                    .then(isLoggedIn => {
                        if (!isLoggedIn) {
                            window.location = "#/home";
                            return;
                        }

                        dataService.myCookie()
                            .then((cookie) => {
                                templates.get("my-cookie")
                                    .then((templateHtml) => {
                                        let templateFunc = handlebars.compile(templateHtml);
                                        let html = templateFunc(cookie.result);
                                        $("#container").html(html);
                                    });
                            })
                            .catch((error) => {
                                toastr.error(error.responseText);
                            })

                    });
            }
        }
    }
};