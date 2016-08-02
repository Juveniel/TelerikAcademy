var people = [
    {firstName: "Yehuda", lastName: "Katz"},
    {firstName: "Carl", lastName: "Lerche"},
    {firstName: "Alan", lastName: "Johnson"}
];

Handlebars.registerHelper('categories', function(items, options) {
    var out = "";

    for(var i = 0, l = items.length; i < l; i += 1) {
        out += "<li>" +
                    "<a href=''>" +
                        options.fn(items[i]) +
                    "</a>" +
               "</li>";
    }

    return out;
});