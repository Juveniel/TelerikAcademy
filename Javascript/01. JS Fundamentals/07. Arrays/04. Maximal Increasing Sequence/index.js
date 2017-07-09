function solve(args){
    var input = (args.toString()).split('\n').map(Number),
        maxSequenceCount = 0,
        tempSequenceCount = 1,
        numbers = [];
    
    var previous = numbers[0];
    for(var j = 1; j < input.length; j++){
        if(input[j] > previous){
            tempSequenceCount += 1;
        }
        else{
            tempSequenceCount = 1;
        }

        if(tempSequenceCount > maxSequenceCount){
            maxSequenceCount = tempSequenceCount;
        }

        previous = input[j];
    }

    console.log(maxSequenceCount);
}

solve(['8\n7\n3\n2\n3\n4\n2\n2\n4']);
