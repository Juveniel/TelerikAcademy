'use strict';

class listNode {
    constructor(value) {
        this._data = value;
    }

    get data() {
        return this._data;
    }

    set data(data) {
        return this._data = data
    }

    get next() {
        return this._next;
    }

    set next(next) {
        return this._next = next;
    }
}

class LinkedList {
    constructor() {
        return this;
    }
    get first() {
        return this._first.data;
    }

    get last() {
        return this._last.data;
    }

    get length() {
        this._length = this._getNodesCount();

        return this._length;
    }

    append(...elements) {
        elements.forEach(function(element){
            let newNode = this._createNewNode(element);

            if(this.length === 0){
                this._first = newNode;
                this._last = newNode;
            }
            else {
                this._last.next = newNode;
            }

            this._last = newNode;
        }, this);

        return this;
    }

    prepend(...elements) {
        let i;

        for (i = elements.length - 1; i >= 0; i -= 1) {
            let newNode = this._createNewNode(elements[i]);
            const temp = this._first;

            this._first = newNode;
            this._first.next = temp;

            if(this.length === 1) {
                this._last = this._first;
            }
        }

        return this;
    }

    insert(...elements) {
        let index = elements.shift(),
            counter = 0,
            currentNode = this._first;

        if(index === 0){
            this.prepend(index);
        }
        else{
            while (counter < index - 1) {
                currentNode = currentNode.next;
                counter += 1;
            }

            elements.forEach(function (element) {
                let node = new listNode(element);

                node.next = currentNode.next;
                currentNode.next = node;
                currentNode = node;

                this._length += 1;
            }, this);
        }

        return this;
    }

    at(index, value) {
        let currentNode = this._first;

        if (index < 0 || index >= this.length) {
            throw new Error('Invalid index');
        }

        for (var i = 0; i < index; i += 1) {
            currentNode = currentNode.next;
        }

        if(value !== undefined && value !== ""){
            currentNode.data = value;
        }

        return currentNode.data;

    }

    removeAt(index) {
        if (index > -1 && index < this._length){

            let current = this._first,
                previous,
                counter = 0;

            if (index === 0){
                this._first = current.next;
            }
            else {

                while(index && counter < index){
                    previous = current;
                    current = current.next;

                    counter += 1;
                }

                previous.next = current.next;
            }

            if(index == this._length - 1){
                this._length -= 1;
            }

            this._length -= 1;


            return current.data;

        } else {

            return null;
        }
    }

    toArray() {
        let list = [],
            node = this._first;

        while (node) {
            list.push(node.data);
            node = node.next;
        }

        return list;
    }

    toString() {
        return this.toArray().join(' -> ');
    }

    *[Symbol.iterator]() {
        let node = this._first;

        while (node) {
            yield node.data;
            node = node.next;
        }
    }


    _createNewNode(value) {
        let newNode = new listNode(value);

        return newNode;
    }

    _getNodesCount(){
        let nodesCount = 0,
            node = this._first;

        while (node) {
            nodesCount += 1;
            node = node.next;
        }

        return nodesCount;
    }


}

const values = [1, 4, 5],
      list = new LinkedList().append(...values).insert(1, 2, 3);

for (const val of list) {
    console.log(val);
}

module.exports = LinkedList;