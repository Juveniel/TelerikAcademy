function solve(args){
    var text = String(args[0]);

   /* text.match(/<orgcase>(.*?)<\/orgcase>/g).map(function(val){

        return val.replace(/<\/?orgcase>/g,'').toUpperCase();
    });*/

    var pattern = "\/<orgcase>(.*?)<\/orgcase>\/";
    var upcase = new RegExp(pattern);
    text.replace(upcase, '');

    console.log(text);
}

solve([ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']);