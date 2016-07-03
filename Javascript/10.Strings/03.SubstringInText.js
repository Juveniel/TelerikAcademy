function solve(args) {
    var
        keyword = String(args[0]),
        sentence = String(args[1]),
        occurencesCount;

    function countOcurrences(sentence, keyword){
        var regExp = new RegExp(keyword, "gi");

        return (sentence.match(regExp) || []).length;
    }

    occurencesCount = countOcurrences(sentence, keyword);

    console.log(occurencesCount);
}