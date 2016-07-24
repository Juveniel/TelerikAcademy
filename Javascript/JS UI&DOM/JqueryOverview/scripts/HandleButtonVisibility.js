function solve(){
    return function(selector){
        ValidateInput(selector);

        var element = $(selector),
            buttons = element.find('.button');

        if(buttons.length > 0){
            buttons.text('hide');

            buttons.on('click', function(){
                var currButton = $(this),
                    nextSibling = currButton.next(),
                    topContent,
                    isValid = false;

                while(nextSibling){
                    if(nextSibling.hasClass('content')){
                        topContent = nextSibling;
                        nextSibling = nextSibling.next();

                        while(nextSibling){
                            if(nextSibling.hasClass('button')){
                                isValid = true;
                                break;
                            }

                            nextSibling = nextSibling.next();
                        }
                        break;
                    } else {
                        nextSibling = nextSibling.next();
                    }
                }

                if (isValid) {
                    if (topContent.css('display') === 'none') {
                        currButton.text('hide');
                        topContent.css('display', '');
                    } else {
                        currButton.text('show');
                        topContent.hide();
                    }
                }
            });
        }
    };

    function ValidateInput(selector){
        if(Object.prototype.toString.call(selector) !== '[object String]'
            || !selector instanceof jQuery
            || $(selector).length === 0){
            throw "Selector must be a string!";
        }
    }
}

module.exports = {'solve' : solve()};