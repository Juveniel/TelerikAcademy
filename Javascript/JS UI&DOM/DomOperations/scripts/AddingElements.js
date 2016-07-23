function solve(){
    return function (element, contents){
        var selectedElement;

        if(typeof(element) !== 'string' && !(element instanceof HTMLElement)){
            throw 'Invalid element type';
        }
        if (typeof(element) === 'string') {
            selectedElement = document.getElementById(element)
        } else {
            selectedElement = element;
        }

        if(!Array.isArray(contents)){
            throw 'Invalid content object type!'
        }

        var outputContent = '';
        for(var i = 0; i < contents.length; i += 1){

            if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
                throw 'Invalid content type';
            }

            outputContent += '<div>' + contents[i] + '</div>';
        }

        selectedElement.innerHTML = outputContent;
    };
}

module.exports = {'solve' : solve()};