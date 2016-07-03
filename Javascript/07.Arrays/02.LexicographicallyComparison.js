function solve(args){
    var input = args[0].split('\n'),
        firstCharArr = String(input[0]),
        secondCharArr = String(input[1]),
        resolved = false,
        counter = 0,
        minimumNumberOfElements;

    minimumNumberOfElements = (firstCharArr.length >= secondCharArr.length) ? secondCharArr.length : firstCharArr.length;

    while(counter < minimumNumberOfElements){
        if(firstCharArr[counter] < secondCharArr[counter]){
            console.log("<");
            resolved = true;
            break;
        }
        else if(firstCharArr[counter] > secondCharArr[counter]){
            console.log(">");
            resolved = true;
            break;
        }

        counter++;
    }

    if(!resolved){
        if (firstCharArr.length > secondCharArr.length) {
            console.log('>');
        }
        else if (firstCharArr.length === secondCharArr.length) {
            console.log('=');
        }
        else {
            console.log('<');
        }
    }
}
