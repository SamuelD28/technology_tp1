// Get the modal
var modal = $("#myModal");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("modal-close")[0];

// Get the button that opens the modal
//var buttons = document.getElementsByClassName("modal-btn");
$(".modal-btn").each(function (index, btn) {
    // When the user clicks the button, open the modal
    $(this).click(function () {
        $("#myModal").css("display", "block");
        $("#myModal").find("#modalPicture").attr("style", "background-image: url('data:image/png;base64," + $(this).children("data").attr("image") + "'); background-size: cover; background-position: center");
        $("#myModal").find("#itemId").attr("value", $(this).children("data").attr("itemId"));
        //$("#myModal").find("#modalContent").text($(this).children("data").attr("name"));
    }
    );
});

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    exitModal();
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == document.getElementById("myModal")) {
        exitModal();
    }
}

function exitModal() {
    $("#quantity").val(1);
    $("#myModal").css("display", "none");
}