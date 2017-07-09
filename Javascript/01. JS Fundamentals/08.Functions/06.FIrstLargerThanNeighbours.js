function FirstLargerThanNeighbours(args){
    var params = (args.toString()).split('\n'),
        size = params[0],
        numbers = (params[1].toString()).split(' ').map(Number),
        numberFound = false,
        foundIdx = 0;

    for(var i = 1; i < size - 1; i++){
        var currentNum = numbers[i];

        if(currentNum > numbers[i - 1] && currentNum > numbers[i + 1]){
            numberFound = true;
            foundIdx = numbers.indexOf(currentNum);
            break;
        }
    }

    if(numberFound){
        console.log(foundIdx);
    }
    else{
        console.log(-1)
    }
}