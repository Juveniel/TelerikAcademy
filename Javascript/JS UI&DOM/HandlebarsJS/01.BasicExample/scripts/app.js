var homepageData = {title: 'Example heading', body: 'example body'},
    htmlTemplate  = document.getElementById('homepage').innerHTML,
    homepageTemplate = Handlebars.compile(htmlTemplate);

document.getElementById('homepage').innerHTML = homepageTemplate(homepageData);