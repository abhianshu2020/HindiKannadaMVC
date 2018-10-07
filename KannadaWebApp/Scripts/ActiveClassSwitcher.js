
    ////When an <li> element in your myMenu area is clicked
    //$('.sidebar ul li a ').click(function () {
    //    //Removes the active class from any <li> elements
    //    $('a.active').removeClass('active');
    //    //Adds it to the current element
    //    $(this).addClass('active');

    //});

$(document).ready(function () {
    $('.sidebar ul li a').click(function () {
        $('a.active').removeClass('active');
        $(this).addClass('active')
    })

    //$('.sidebar ul li a').on("click", function () {
    //    $.ajax({
    //        url: "/Home/Fruits",
    //        type: "GET",
    //    })
    //    .done(function (partialViewResult) {
    //        $("#refTable").html(partialViewResult);
    //    });
    //});

});

