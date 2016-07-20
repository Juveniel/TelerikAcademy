function LargerThanNeighbours(args){
    var params = (args.toString()).split('\n'),
        size = params[0],
        numbers = (params[1].toString()).split(' ').map(Number),
        sequenceCount = 0;

   // console.dir(numbers);

    for(var i = 1; i < size - 1; i++){
        var currentNum = numbers[i];

        if(currentNum > numbers[i - 1] && currentNum > numbers[i + 1]){
            sequenceCount++;
        }
    }

    console.log(sequenceCount);
}

LargerThanNeighbours(['6\n-26 -25 -28 31 2 27']);