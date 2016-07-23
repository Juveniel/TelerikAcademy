function solve(){
    return function(selector, count){
        var element = $(selector);

        ValidateCount(selector, count);

        var list = $('<ul class="items-list"></ul>').appendTo(element);

        for(var i = 0; i < count; i += 1){
            $('<li>List item #'+ i +'</li>')
                .addClass('list-item')
                .appendTo(list);
        }

        return list
    };

    function ValidateCount(selector, count){
        var intRegex = /^\d+$/;

        if(intRegex.test(count) && count < 1){
            throw "Count must be a number and bigger than 1!";
        }
        else if(!intRegex.test(count)){
            throw "Count must be a valid number!";
        }
        else if(Object.prototype.toString.call(selector) !== '[object String]'){
            throw "Selector must be a string!"
        }
    }
}

module.exports = {'solve' : solve()};