/*
Commands
allert(string) popup
console.log(string) prints in the browser console (f12)
array.push(item) add item to array
array.pop() delete last item
dictionaries = python
prompt(String) makes a popup question and return the results to a variable
loops and ifs = c and cpp
functions life python "def=function"
.innerHTML injects a html code
window.open(link) opens a new page

HTML
onclick="function"
onmouseover="fucntion"
onmouseout="function"
onload="function"
*/

function button(){
    document.getElementById("thx").innerHTML="<b>Thanks for pressing me</b>";
}
function inside(element){
    element.innerHTML="You are inside";
}
function out(element){
    element.innerHTML="You are out";
}
function change(element){
    console.log(element.value);
}