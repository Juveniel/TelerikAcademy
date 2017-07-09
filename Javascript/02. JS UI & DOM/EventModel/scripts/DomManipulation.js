function solve(){
    return function (element){
        var el = ParseInput(element),
            buttons = el.getElementsByClassName('button');

        ChangeButtonContents(buttons, 'hide');
        RegisterClickButtonEvent(buttons);
    };

    function ParseInput(element){
        var selectedElement;

        if(typeof(element) !== 'string' && !(element instanceof HTMLElement)){
            throw 'Invalid element type';
        }
        if (typeof(element) === 'string') {
            selectedElement = document.getElementById(element)
        } else {
            selectedElement = element;
        }

        return selectedElement;
    }

    function ChangeButtonContents(buttons, content){
        for(var i = 0; i < buttons.length; i += 1){
            buttons[i].innerHTML = content;
        }
    }

    function HandleButtonClickEvent(button){
        var nextElement = button.nextElementSibling,
            nextElementVisibility,
            topmostContent,
            isValid = false;

        while(nextElement){
            if(nextElement.className === 'content'){
                topmostContent = nextElement;
                nextElement = nextElement.nextSibling;

                while(nextElement){
                    if(nextElement.className === 'button'){
                        isValid = true;
                        break;
                    }
                    nextElement = nextElement.nextElementSibling;
                }
                break;
            } else {
                nextElement = nextElement.nextElementSibling;
            }
        }

        if (isValid) {
            if (topmostContent.style.display === 'none') {
                topmostContent.style.display = '';
                button.innerHTML = 'hide';
            } else {
                topmostContent.style.display = 'none';
                button.innerHTML = 'show';
            }
        }
    }

    function RegisterClickButtonEvent(buttons){
        for(var i = 0; i < buttons.length; i += 1){
            buttons[i].addEventListener('click', function() {
                HandleButtonClickEvent(this);
            });
        }
    }
}

module.exports = {'solve' : solve()};