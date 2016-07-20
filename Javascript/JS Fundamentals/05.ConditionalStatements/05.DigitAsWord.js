function solve(args){
    var numToWord = '';
    var input = Number(args[0]);

    switch (input){
        case 0:
            numToWord = 'zero';   break;
        case 1:
            numToWord = 'one';  break;
        case 2:
            numToWord = 'two'; break;
        case 3:
            numToWord = 'three'; break;
        case 4:
            numToWord = 'four'; break;
        case 5:
            numToWord = 'five'; break;
        case 6:
            numToWord = 'six'; break;
        case 7:
            numToWord = 'seven'; break;
        case 8:
            numToWord = 'eight'; break;
        case 9:
            numToWord = 'nine'; break;
        default:
            numToWord ='not a digit';
    }

    console.log(numToWord);
}

solve([1]);
solve([10]);