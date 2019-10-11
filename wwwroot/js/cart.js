$(".remove-item-btn").each(function (index, btn) {
    // When the user clicks the button, open the modal
    $(this).click(function (event) {
        event.stopPropagation();
        var itemId = $(this).parents(".modal-btn").find("data").attr("itemId")
        $.post("/Home/DecreaseQuantityItem", { itemId: itemId, quantity: 1 }, function (data, status) {
            if (status == "success") {
                $(".menu-item").each(function (index, item) {
                    var JQItem = $(item);
                    var JQData = JQItem.find("data");
                    if (JQData.attr("itemId") == itemId) {
                        let cart = JSON.parse(data);
                        updateItemQuantity(JQItem, parseInt(JQData.attr("quantity")) - 1);
                        updateItemDisplay(JQItem)
                        var cartNav = $("#cartNav").children('span');
                        cartNav.text(cart["itemCount"]);
                        updateMainMessageDisplay();
                        updatePriceDisplay(cart["totalPrice"]);
                        return;
                    }
                });
            }
        });
    });
});

function updateItemQuantity(menuItem, newQuantity) {
    menuItem.find("data").attr("quantity", newQuantity);
}

function updateItemDisplay(menuItem) {
    var quantity = parseInt(menuItem.find("data").attr("quantity"));
    if (quantity < 1) {
        menuItem.remove();
        return true;
    }
    menuItem.find(".item-quantity").text(quantity);
    return false;
}

function updateMainMessageDisplay() {
    if ($("#cartItems").children().length == 0) {
        $("#emptyCartMessage").show();
    }
    else {
        $("#emptyCartMessage").hide();
    }
}

function updatePriceDisplay(price) {
    if ($("#cartItems").children().length == 0) {
        $("#totalPrice").hide();
        return;
    }
    $("#totalPrice").show();
    $("#totalPrice").find(".price").text(price.toFixed(2) + "$");
}

new CartModal();
updateMainMessageDisplay();
updatePriceDisplay();