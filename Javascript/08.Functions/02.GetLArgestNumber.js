function GetLargestNumber(args){
    var numbers = args[0].split(' ').map(Number);


    console.dir(Math.max.apply(Math, numbers));
}