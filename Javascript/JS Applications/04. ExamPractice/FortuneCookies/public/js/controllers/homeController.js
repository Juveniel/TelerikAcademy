let homeController = {
    get(dataService, template) {
        return {
            index() {
                var cookies;
                dataService.cookies()
                    .then((cookiesResponse) => {
                        cookies = cookiesResponse;
                        console.log(cookies);

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
            }
        }
    }
};