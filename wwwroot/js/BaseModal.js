﻿class Modal {
    constructor(modalId, modalClose, modalOpen, onOpenning, onClosing) {
        this.modalId = modalId;
        this.modalClose = modalClose;
        this.modalOpen = modalOpen;
        this.onOpenning = onOpenning;
        this.onClosing = onClosing;

        var modal = this;



        $(this.modalOpen).each(function (index, btn) {
            // When the user clicks the button, open the modal
            $(btn).click(function () {
                modal.openModal(this);
            });
        });

        window.onclick = function (event) {
            if (event.target == $(modal.modalId)[0]) {
                modal.exitModal();
            }
        }

        // When the user clicks on <span> (x), close the modal
        $(this.modalClose).each(function (index, btn) {
            // When the user clicks the button, open the modal
            $(btn).click(function () {
                modal.exitModal(this);
            });
        });
    }

    openModal(sender) {
        $(this.modalId).css("display", "block");
        this.onOpenning(sender);
    }

    exitModal() {
        $(this.modalId).css("display", "none");
        this.onClosing();
    }
}
