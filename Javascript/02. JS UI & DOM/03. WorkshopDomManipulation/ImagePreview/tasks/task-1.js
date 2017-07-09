function solve() {
    return function (selector, items) {
        var container = document.querySelector(selector),
            preview = createPreview(items),
            sidebar = createSidebar(items);

        container.appendChild(preview);
        container.appendChild(sidebar);
    };

    function createFilter(items){
        var filterNode = document.createElement('div'),
            filterTitleNode = document.createElement('h2'),
            filterNodeInput = document.createElement('input');

        filterNode.className = 'filter-top';
        filterTitleNode.innerHTML = 'Filter';
        filterNodeInput.type = 'text';
        filterNodeInput.className = 'search-images';
        filterNodeInput.value = '';

        filterNodeInput.addEventListener('input', function() {
            var searchString = this.value.toString();

            for(var i = 0; i < items.length; i++){
                    var currentItem = document.getElementsByClassName('image-container')[i],
                    itemTitle = items[i].title.toString();

                if(itemTitle.toLowerCase().indexOf(searchString) === -1){
                    currentItem.style.display = 'none';
                }
                else{
                    currentItem.style.display = 'block';
                }
            }
        });

        filterNode.appendChild(filterTitleNode);
        filterNode.appendChild(filterNodeInput);

        return filterNode;
    }

    function createSidebar(items){
        var sidebarNode = document.createElement("div"),
            filter = createFilter(items),
            itemHolder = document.createElement('div'),
            itemList = document.createElement('ul');

        sidebarNode.className = "image-container-wrapper";
        itemHolder.className = 'items-wrappers';
        itemList.className = 'image-container-outer';

        for(var i = 0; i < items.length; i += 1){
            var newListItemNode = document.createElement('li'),
                newListItemNodeTitle = document.createElement('h3'),
                newListItemImage = document.createElement('img');

            newListItemNode.className = 'image-container';
            newListItemNodeTitle.innerHTML = items[i].title;
            newListItemImage.src = items[i].url;

            newListItemNode.appendChild(newListItemNodeTitle);
            newListItemNode.appendChild(newListItemImage);


            newListItemNode.addEventListener('click', function() {
                var previewHolder = document.getElementsByClassName('image-preview-item')[0],
                    previewTitle = document.getElementsByClassName('image-preview-title')[0];

                previewHolder.src = this.getElementsByTagName('img')[0].src;
                previewTitle.innerHTML = this.getElementsByTagName('h3')[0].innerHTML;
            });

            newListItemNode.addEventListener('mouseover', function() {
                this.style.backgroundColor = "red";
            });

            newListItemNode.addEventListener('mouseout', function() {
                this.style.backgroundColor = "white";
            });

            itemList.appendChild(newListItemNode);
        }

        itemHolder.appendChild(itemList);
        sidebarNode.appendChild(filter);
        sidebarNode.appendChild(itemHolder);

        return sidebarNode;
    }

    function createPreview(items){
        var previewNode = document.createElement('div'),
            previewNodeTitle = document.createElement('h1'),
            previewNodeImage = document.createElement('img');

        previewNode.className = 'image-preview';
        previewNodeTitle.className = 'image-preview-title';
        previewNodeImage.className = 'image-preview-item';

        previewNodeTitle.innerHTML = items[0].title;
        previewNodeImage.src = items[0].url;

        previewNode.appendChild(previewNodeTitle);
        previewNode.appendChild(previewNodeImage);

        return previewNode;
    }
}

module.exports = solve;