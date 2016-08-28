var eventHandler = (function(){
	function onButtonClick(event, arguments){
		var browserName = window.navigator.appName,
			isMozilla = browserName === 'Mozilla';

		if(isMozilla){
			alert('Yes');
		}
		else{
			alert('No');
		}
	}

	return{
		onButtonClick: onButtonClick
	}
}());