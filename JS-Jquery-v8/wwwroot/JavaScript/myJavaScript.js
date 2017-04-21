
$(document).ready(function () {
    $("li").mouseover(function () {
        var id = $(this).attr("customerID");
        console.log(id);
        $("div").html(id);
    });
});


