

MYAPP = {
	
	Prova : function(){
		alert("Questa è una prova !!!");
	},

		showLiveToast : function (elementId) {
		var toastEl = document.getElementById(elementId);
		if (toastEl) {
				var toast = new bootstrap.Toast(toastEl);
				toast.show();
		} else {
				console.error("Element with ID '" + elementId + "' not found.");
		}
	}
}