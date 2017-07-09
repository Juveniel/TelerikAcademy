document.addEventListener('DOMContentLoaded', function(){ 
    showDefaultActiveTab();
    activateAllTabsActiveClass();   
}, false);

function openNavigationTab(evt, navTitle) {
    var i, tabcontent, tablinks;

    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tabcontent.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    document.getElementById(navTitle).style.display = "block";
    evt.currentTarget.className += " active";
}

function hasClass(element, cls) {
    return (' ' + element.className + ' ').indexOf(' ' + cls + ' ') > -1;
}

function showDefaultActiveTab(){
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        if(hasClass(tablinks[i], "active")){
            tablinks[i].click();
        }        
    }
}

function setContentNavigationActive(element){
    var selector, elems, makeActive;

    selector = '#' + element + ' .content-nav li';
    elems = document.querySelectorAll(selector);

    makeActive = function () {
        for (var i = 0; i < elems.length; i++){
            elems[i].classList.remove('active');
        }
            
        this.classList.add('active');
    };

    for (var i = 0; i < elems.length; i++){
        elems[i].addEventListener('mousedown', makeActive);
    }        
}

function activateAllTabsActiveClass(){
    var tabs = ["news", "sport", "emissions", "curiosities", "i-reporter", "this-morning"];
    for(var i = 0; i < tabs.length; i++){
        setContentNavigationActive(tabs[i]);
    }    
}