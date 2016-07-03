function solve(args){
    var numbers = (args.toString()).split('\n').map(Number),
        maxSequenceCount = 1,
        tempSequenceCount = 1;

    for(var j = 0; j < numbers.length; j++){
        if(numbers[j] == numbers[j + 1]){
            tempSequenceCount += 1;
        }
        else{
            tempSequenceCount = 1;
        }

        if(tempSequenceCount >= maxSequenceCount){
            maxSequenceCount = tempSequenceCount;
        }
    }

    console.log(maxSequenceCount);
}