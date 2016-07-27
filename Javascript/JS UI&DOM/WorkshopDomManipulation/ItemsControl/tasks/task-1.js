function solve() {
    return function(selector, isCaseSensitive){
        var container = document.querySelector(selector),
            addControls = createAddControls(),
            searchControls = createSearchControls(),
            resultControls = createResultControls();

        container.className = 'items-control';

        container.appendChild(addControls);
        container.appendChild(searchControls);
        container.appendChild(resultControls);
    };

    function createAddControls(){
        var controlContainer = document.createElement('div'),
            controlLabel = document.createElement('label'),
            controlInput = document.createElement('input'),
            controlButton = document.createElement('button');

        controlContainer.className = 'add-controls';
        controlLabel.innerHTML = 'Enter text';
        controlButton.innerHTML = 'Add';
        controlButton.className = 'button';

        controlButton.addEventListener('click', function() {
            var itemsList = document.getElementsByClassName('items-list')[0],
                newItem = document.createElement('li'),
                newItemRemoveBtn = document.createElement('button');

            newItemRemoveBtn.className = 'button';
            newItemRemoveBtn.innerHTML = 'X';
            newItemRemoveBtn.addEventListener('click', function(){
                this.parentNode.parentNode.removeChild(this.parentNode);
            });

            newItem.className = 'list-item';
            newItem.innerHTML = controlInput.value;
            newItem.appendChild(newItemRemoveBtn);

            itemsList.appendChild(newItem);
        });

        controlContainer.appendChild(controlLabel);
        controlContainer.appendChild(controlInput);
        controlContainer.appendChild(controlButton);

        return controlContainer;
    }

    function createSearchControls(){
        var controlContainer = document.createElement('div'),
            controlLabel = document.createElement('label'),
            controlInput = document.createElement('input');

        controlContainer.className = 'search-controls';
        controlLabel.innerHTML = 'Search:';

        //todo implement search logic

        controlContainer.appendChild(controlLabel);
        controlContainer.appendChild(controlInput);

        return controlContainer;
    }

    function createResultControls(){
        var controlContainer = document.createElement('div'),
            controlResultsList = document.createElement('ul');

        controlContainer.className = 'result-controls';
        controlResultsList.className = 'items-list';

        controlContainer.appendChild(controlResultsList);


        return controlContainer;
    }
}

module.exports = solve;