window.global = {
  openModal: function (popupId) {
    popupId = "#" + popupId;
    $(popupId).modal("show");
  },
  closeModal: function (popupId) {
    popupId = "#" + popupId;
    $(popupId).modal("hide");
  },
};
