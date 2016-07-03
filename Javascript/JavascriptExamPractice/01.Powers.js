function solve(params){
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        currNumber, pevNum, nextNum,
        currentTransformation = [],
        i , j = 0;

    while(j < nk[1]){
        for(i = 0; i < nk[0]; i += 1){
            currNumber = Number(s[i]);

            var prevNum = Number(i === 0 ? s[s.length - 1] : s[i - 1]);
            var nextNum = Number(i === nk[0] - 1 ? s[0] : s[i + 1]);

            if(currNumber === 0){
                currentTransformation.push(Math.abs(prevNum - nextNum));
            }
            else if(isEven(currNumber)){
                currentTransformation.push(Math.max(prevNum, nextNum));
            }
            else if(currNumber === 1){
                currentTransformation.push(prevNum + nextNum);
            }
            else if(!isEven(currNumber)){
                currentTransformation.push(Math.min(prevNum, nextNum));
            }
        }

        j+=1;
        s = currentTransformation;
        currentTransformation = [];
    }
    
    console.log(calculateSum());
    
    function isEven(num){
        if(Number(num) % 2 === 0){
            return true;
        }

        return false;
    }

    function calculateSum(){
        var total = 0;

        s.forEach(function (item) {
            total += item;
        });

        return total;
    }
}
//solve(['5 1\n9 0 2 4 1']);
//solve(['10 3\n1 9 1 9 1 9 1 9 1 9']);
solve(['10 10','0 1 2 3 4 5 6 7 8 9']);