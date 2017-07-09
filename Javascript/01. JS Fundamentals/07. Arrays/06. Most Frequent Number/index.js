function solve(args){
    var numbers = (args.toString()).split('\n').map(Number),
        numbersLen = numbers.length;

    if(numbersLen == 0){
        return null;
    }
    var modeMap = {},
        maxEl = numbers[0],
        maxCount = 1;

    for(var j = 1; j < numbersLen; j++)
    {
        var el = numbers[j];

        if (modeMap[el] == null)
            modeMap[el] = 1;
        else
            modeMap[el]++;

        if (modeMap[el] > maxCount)
        {
            maxEl = el;
            maxCount = modeMap[el];
        }
        else if (modeMap[el] == maxCount)
        {
            maxEl += '&' + el;
            maxCount = modeMap[el];
        }
    }

    console.log(maxEl + ' (' + maxCount + ' times)');
}

solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);