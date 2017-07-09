function solve(args){
    var length = +args;

    var matrix = [];

    for(var i=0; i< length; i++) {
        matrix[i] = [];
        for(var j= 0; j<length ; j++) {
            matrix[i][j] = j + i + 1;
        }
    }

    for(var k = 0; k < matrix.length; k++){
        console.log(matrix[k].join(' '));
    }
}


solve([4]);
