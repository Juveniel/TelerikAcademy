function EnglishDigit(args){
    var number = String(args[0]),
        lastDigit = number.slice(-1),
        words = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];

    console.log(words[lastDigit]);
}