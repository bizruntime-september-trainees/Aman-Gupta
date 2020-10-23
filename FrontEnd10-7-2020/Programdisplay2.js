function doFirst()
{
    copyrandomimg=getElementById('randomimg');
    copyrandomimg.addEventListener( "dragstart",startDrag,false);
    copttoleftbox=getElementById('leftbox');
    copytoleftbox.addEventListener('dragenter',function(e){e.preventDefault();} ,false);
    copytoleftbox.addEventListener('gragover',function(e){e.preventDefault();},false);
    copytoleftbox.addEventListener('drop',dropped,false);
}
function startDrag(e){
    var code='<img id="randomimg" src="E:\imgtest.jpg">';
    e.dataTransfer.setData('Text',code)
}
function dropped(e){
    e.preventDefault();
    leftbox.innerHTML=e.dataTransfer.getData('Text');
}
window.addEventListener("load",doFirst,false);