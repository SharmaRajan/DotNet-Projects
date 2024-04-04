// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    function Toast(type, css, msg) {
        this.type = type;
        this.css = css;
        this.msg = msg ;
    }

    var toasts = [
        new Toast('error', 'toast-bottom-full-width'),
        new Toast('info', 'toast-top-full-width'),
        new Toast('warning', 'toast-top-left'),
        new Toast('success', 'toast-top-right'),
        new Toast('warning', 'toast-bottom-right'),
        new Toast('error', 'toast-bottom-left')
    ];

    //toastr.options.positionClass = 'toast-top-full-width';
    //toastr.options.extendedTimeOut = 0; //1000;
    //toastr.options.timeOut = 1000;
    //toastr.options.fadeOut = 250;
    //toastr.options.fadeIn = 250;

    //Replace options.fadeIn with options.showDuration
    //Replace options.onFadeIn with options.onShown
    //Replace options.fadeOut with options.hideDuration
    //Replace options.onFadeOut with options.onHidden

    // Using jquery Easing plugin
    //toastr.options.showEasing = 'easeOutBounce';
    //toastr.options.hideEasing = 'easeInBack';
    //toastr.options.closeEasing = 'easeInBack';

    // Animation method
    //toastr.options.showMethod = 'slideDown';
    //toastr.options.hideMethod = 'slideUp';
    //toastr.options.closeMethod = 'slideUp';

    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": true,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "2000",
        "extendedTimeOut": "3000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut",
        "onShown": "250",
        "onHidden": "250",
        "closeMethod": "fadeOut",
        "closeDuration": "300",
        "closeEasing": "linear",
        "rtl":true
    }

    var i = 0;

    $('#tryMe').click(function () {
        $('#tryMe').prop('disabled', true);
        delayToasts();
    });

    function delayToasts() {
        if (i === toasts.length) { return; }
        var delay = i === 0 ? 0 : 2100;
        window.setTimeout(function () { showToast(); }, delay);

        // re-enable the button        
        if (i === toasts.length - 1) {
            window.setTimeout(function () {
                $('#tryMe').prop('disabled', false);
                i = 0;
            }, delay + 1000);
        }
    }

    function showToast() {
        var t = toasts[i];
        toastr.options.positionClass = t.css;
        toastr[t.type](t.msg);
        i++;
        delayToasts();
    }
})
