function AppearanceCount(args){
    var params = (args.toString()).split('\n');

    var size = Number(params[0]),
        numbers = (params[1].toString()).split(' ').map(Number),
        searchNum = Number(params[2]),
        appearances = 0;
    
    for(var i = 0; i < size; i++) {
        if (numbers[i] == searchNum) {
            appearances++;
        }
    }

    console.log(appearances);
}

AppearanceCount(['8\n28 6 21 6 -7856 73 73 -56\n73']);

