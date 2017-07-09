function solve(args){
    var people = [],
        i;

    function fillPeopleArr(){
        for(i = 0; i < args.length; i += 3){
            people.push(createPerson(args[i], args[i + 1], Number(args[i + 2])));
        }
    }

    function createPerson(firstName, lastName, age) {
        return{
            'firstName' : firstName,
            'lastName' : lastName,
            'age' : age
        }
    }

    function printYoungestPersonName(){
        var youngestPerson = people[0];

        for(i = 1; i < people.length; i++){
            var currPerson = people[i];

            if(youngestPerson.age > currPerson.age){
                youngestPerson = currPerson;
            }
        }

        console.log(youngestPerson.firstName + ' ' + youngestPerson.lastName);
    }

    fillPeopleArr();
    printYoungestPersonName();
}

solve(
    [
        'Penka', 'Hristova', '61',
        'System', 'Failiure', '88',
        'Bat', 'Man', '16',
        'Malko', 'Kote', '72'
    ]
);