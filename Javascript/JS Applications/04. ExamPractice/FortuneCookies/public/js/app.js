let router = new Navigo(null, true);
var handlebars = handlebars || Handlebars;

let homeControllerInstance = homeController.get(dataService, templates),
    usersControllerInstance = usersController.get(dataService, templates);

router
    .on("home", homeControllerInstance.index)
    .on("users", usersControllerInstance.list)
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

$("#main-nav").on("click", "li", function(ev) {
    $("#main-nav .active").removeClass("active");
    $(this).addClass("active");
});

$(function() {
    $("#main-nav .active").removeClass("active");
    let $currentPageNavButton = $(`#main-nav a[href="${window.location.hash}"]`).parents("li");
    $currentPageNavButton.addClass("active");
});