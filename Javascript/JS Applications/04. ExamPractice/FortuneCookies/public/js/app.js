let router = new Navigo(null, true);
var handlebars = handlebars || Handlebars;

let homeControllerInstance = homeController.get(dataService, templates),
    usersControllerInstance = usersController.get(dataService, templates),
    categoriesControllerInstance = categoriesController.get(dataService, templates);

router
    .on("home", () => {
        const params = getQueryParams(window.location.hash);
        homeControllerInstance.index(params);
    })
    .on("users", usersControllerInstance.list)
    .on("categories", categoriesControllerInstance.list)
    .on("login", usersControllerInstance.login)
    .on("logout", usersControllerInstance.logout)
    .on("my-cookie", usersControllerInstance.myCookie)
    .on("cookie-add", usersControllerInstance.shareCookie)
    .on(() => {
        $("#main-nav .home a").addClass("active");
        router.navigate("/home");
    })
    .resolve();

dataService.isLoggedIn()
    .then(function(isLoggedIn) {
        if (isLoggedIn) {
            $(document.body).addClass("logged-in");
        }
    });

function getQueryParams(hash) {
    hash = String(hash);

    let params = {};
    if (hash.indexOf('?') < 0) {
        return params;
    }

    const inputParams = hash.split('?')[1].split('&');
    inputParams.forEach(param => {
        const split = param.split('=');
        params[split[0]] = split[1];
    });

    return params;
}

$("#main-nav").on("click", "li", function(ev) {
    $("#main-nav .active").removeClass("active");
    $(this).addClass("active");
});

$(function() {
    $("#main-nav .active").removeClass("active");
    let $currentPageNavButton = $(`#main-nav a[href="${window.location.hash}"]`).parents("li");
    $currentPageNavButton.addClass("active");
});