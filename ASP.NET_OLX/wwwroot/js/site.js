﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
	return new bootstrap.Tooltip(tooltipTriggerEl)
})


function setFavourite(id) {
	$favourite = $('#favourite');
	$functName = null;
	$element = $(`#${id}`);
	
	if ($element.text() == "favorite") {
		$functName = "Remove";
		$element.text('favorite_border');
	}
	else {
		$functName = "Add";
		$element.text('favorite');
	}
	$.get(`/Favourite/${$functName}?id=${id}`).done((res) => {
		if (res == 0)
			$favourite.text('');
		else $favourite.text(`(${res})`);
	});
}

