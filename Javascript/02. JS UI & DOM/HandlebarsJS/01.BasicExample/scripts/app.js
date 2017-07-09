var homepageData = {title: 'Example heading', body: 'example body'},
    htmlTemplate  = $('#homepage').html(),
    homepageTemplate = Handlebars.compile(htmlTemplate);

$('#homepage').html(homepageTemplate(homepageData));