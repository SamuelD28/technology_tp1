class CartModal extends Modal {
    constructor() {
        super('#myModal', '.modal-close', '.order-btn',
            function (sender) { this.openFun(sender) },
            function (sender) { this.closeFun(sender) });
    }


    openFun = function (sender) {
        $(this.modalId + " .totalPrice").text($("#totalPrice .price").text());
    }

    closeFun = function (sender) {
    }
}