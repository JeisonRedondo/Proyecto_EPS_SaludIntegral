// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var limit = 1;
$('input.checkbox-account').on('change', function(evt) {
   if($(this).siblings(':checked').length >= limit) {
       this.checked = false;
   }
});

$('input.checkbox-account').on('change', function(evt) {
    const spanToChange = document.getElementById('typeAccount');
    if(document.getElementById('doctor').checked) {
        document.getElementById("continue").style.visibility = "visible";
        spanToChange.innerHTML = "Doctor!";
    } else if(document.getElementById('patient').checked) {
        document.getElementById("continue").style.visibility = "visible";
        spanToChange.innerHTML = "Patient!";
    } else {
        document.getElementById("continue").style.visibility = "hidden";
    }
 });