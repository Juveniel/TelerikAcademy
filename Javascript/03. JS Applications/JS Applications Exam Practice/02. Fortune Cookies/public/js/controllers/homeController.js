let homeController = {
    get(dataService, templates) {
        return {
            index(params) {
                var cookies;
                dataService.cookies()
                    .then((cookiesResponse) => {
                        cookies = cookiesResponse.result;
                        //console.log(cookies);

                        if(params.userId) {
                            const userId = params.userId;

                            if(cookies.length > 0) {
                                cookies = cookies.filter(cookie => {
                                    return cookie.userId === userId;
                                });
                            }
                        }

                        if(params.category) {
                            const category = params.category;
                            
                            cookies = cookies.filter(cookie => {
                                return cookie.category === category;
                            });
                        }

                        return templates.get("home");
                    })
                    .then((templateHtml) => {

                        let templateFunc = handlebars.compile(templateHtml);
                        let html = templateFunc(cookies);
                        $("#container").html(html);

                        $(".btn-like-dislike").on("click", function(ev) {
                            let type = $(this).attr("data-type");
                            let cookieId = $(this).parents("li").attr("data-id");
                            console.log(type);
                            console.log(cookieId);
                            dataService.rateCookie(cookieId, type)
                                .then();

                        });
                    });
            },


        }
    }
};