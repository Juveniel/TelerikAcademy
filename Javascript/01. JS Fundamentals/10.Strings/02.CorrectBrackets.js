function solve(args){
    var expression = String(args[0]),
        isCorrect;

    function checkBrackets(str){
        var len = expression.length,
            currentChar = '',
            leftBracketsCount = 0,
            rightBracketsCount = 0,
            isCorrect, i;

        for(i = 0 ; i < len ; i++){
            currentChar = expression.charAt(i);

            if(currentChar === '('){
                leftBracketsCount += 1;
            }
            else if(currentChar === ')'){
                rightBracketsCount += 1;
            }

            if(leftBracketsCount < rightBracketsCount){
                isCorrect = false;
            }
        }

        if(leftBracketsCount === rightBracketsCount){
            isCorrect = true;
        }
        else{
            isCorrect = false;
        }

        return isCorrect;
    }

    isCorrect = checkBrackets(expression);

    if(isCorrect){
        console.log("Correct");
    }
    else{
        console.log("Incorrect");
    }
}

solve(['((a+b)/5-d)']);