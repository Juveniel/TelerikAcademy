let categoriesController = {
    get(dataService, templates) {
        return {
            list() {
                let categories;
                dataService.isLoggedIn()
                    .then(isLoggedIn => {
                        if(!isLoggedIn) {
                            window.location = "#/login";
                            return;
                        }

                        dataService.getCategories()
                            .then((categoriesResponse) => {
                                categories = categoriesResponse;

                                return templates.get("categories");
                            })
                            .then((templateHtml) => {
                                let templateFunc = handlebars.compile(templateHtml);
                                let html = templateFunc(categories);
                                $("#container").html(html);
                            })
                            .catch((error) => {
                                toastr.error(error.responseText);
                                console.dir(error);
                            });
                    });
            }
        }
    }
};