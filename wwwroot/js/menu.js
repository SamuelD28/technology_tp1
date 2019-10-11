var menuModal = new MenuModal();

$(document).ready(function () {
    // bind 'myForm' and provide a simple callback function 
    $('#addForm').submit(function (event) {
        var itemId = parseInt($(this).find("#itemId").attr("value"));
        var quantity = parseInt($(this).find("#quantity").val());
        $.post("/Home/AddItemToCart", { itemId: itemId, quantity: quantity }, function (data, status) {
            menuModal.exitModal();
            if (status == "success") {
                let cart = JSON.parse(data);
                updateCartCount(cart["itemCount"]);
            }
            });
        return false;
    });
}); 