function solve(args) {
    var result,
        text = args[0],
        offset = args[1],
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        };
    result = transformation(encryption(compression(text), offset));

    function compression(text) {
        var charArray = text.split(""),
            counter = 1,
            lettersToCompressSymbol = "",
            lettersToCompressLength = 0,
            lettersToCompressStartPoss = 0,
            noMoreLettersToCompress = true;
        while(1){
            for (var i = 0; i < charArray.length; i++) {
                if (i != charArray.length - 1) {
                    if (charArray[i] == charArray[i + 1]) {
                        counter++;
                    }
                    else{
                        if(counter > 2){
                            lettersToCompressSymbol = charArray[i];
                            lettersToCompressLength = counter;
                            lettersToCompressStartPoss = i + 1 - lettersToCompressLength;
                            counter = 1;
                            noMoreLettersToCompress = false;
                            break;
                        }
                        counter = 1;
                    }
                }
                else{
                    if(counter > 2){
                        lettersToCompressSymbol = charArray[i];
                        lettersToCompressLength = counter;
                        lettersToCompressStartPoss = i + 1 - lettersToCompressLength;
                        noMoreLettersToCompress = false;
                        counter = 1;
                    }
                }
            }
            if(!noMoreLettersToCompress) {
                charArray.splice(lettersToCompressStartPoss, lettersToCompressLength,
                    (lettersToCompressLength + "" + lettersToCompressSymbol));
                noMoreLettersToCompress = true;
            }
            else{
                break;
            }
        }
        return charArray.join("");
    }

    function encryption(text, offset) {
        offset = offset || 0;
        var encryptedText = [],
            asciiCodeOfEncrypt = 0,
            asciiCodeOfNoneEncrypt = 0,
            encryptedAlphabet = CONSTANTS.ALPHABET.substr(26 - offset, offset) +
                CONSTANTS.ALPHABET.substr(0, 26 - offset);

        for (var i = 0; i < text.length; i++) {
            if (checkIfLetter(text[i])) {
                asciiCodeOfEncrypt = encryptedAlphabet[CONSTANTS.ALPHABET.indexOf(text[i])];
                asciiCodeOfNoneEncrypt = text[i];
                encryptedText.push(asciiCodeOfEncrypt.charCodeAt(0) ^ asciiCodeOfNoneEncrypt.charCodeAt(0));
            }
            else {
                encryptedText.push(text[i]);
            }
        }

        function checkIfLetter(symbol) {
            var asciiCode = symbol.charCodeAt(0);
            if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
                return true;
            }
            return false;
        }

        return encryptedText.join("");
    }

    function transformation(text) {
        var sumOfAllEvenDigits = 0,
            productOfAllOddDigits = 1;
        for (var i = 0; i < text.length; i++) {
            if (!(parseInt(text[i]) % 2)) {
                sumOfAllEvenDigits += parseInt(text[i]);
            }
            else {
                productOfAllOddDigits *= parseInt(text[i]);
            }
        }
        return sumOfAllEvenDigits + "\n" + productOfAllOddDigits;
    }

    return result;
}
test = [
    'aaaabbbccccaa',
    '3'

];
console.log(solve(test));