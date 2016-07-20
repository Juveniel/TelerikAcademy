function solve(args){
    Array.prototype.remove = function(value){
        while(this.indexOf(value) !== -1){
            this.splice(this.indexOf(value), 1);
        }

        return this;
    };

    args.remove(args[0]);

    return args.join('\n');
}

solve([ '1', '2', '3', '2', '1', '2', '3', '2' ]);