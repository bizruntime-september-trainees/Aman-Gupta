//$(function (){code});
$(document).ready(function () {
    console.log("we are using jQuery");
    //$ is jQuery
    $('p').click(function () {
        console.log("you clicked on p", this);
        //      $(this).hide();
        //     //$("#a").hide();
        //    // $(".aa").hide();
        $('*').click();
    });
    //$('*').click();
   


})
