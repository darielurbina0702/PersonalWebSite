var googleHelper = (function ($) {
    "use strict"
    var module = {
        onready: function () {
            ga('send', {
                hitType: 'pageview',
                page: location.pathname
            });
        }    
    };
    return module;
})(jQuery);
