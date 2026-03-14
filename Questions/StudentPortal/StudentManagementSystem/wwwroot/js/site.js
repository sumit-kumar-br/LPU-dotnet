document.addEventListener("DOMContentLoaded", function () {
	document.querySelectorAll("[data-confirm]").forEach(function (element) {
		element.addEventListener("click", function (event) {
			var message = element.getAttribute("data-confirm") || "Are you sure?";
			if (!window.confirm(message)) {
				event.preventDefault();
			}
		});
	});
});
