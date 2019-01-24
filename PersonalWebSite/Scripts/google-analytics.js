var googleHelper = (function ($) {
    "use strict"
    var module = {
        onready: function () {
            ga('send', 'pageview', location.pathname + '/durbina.pdf');            
            console.log(location.pathname + '/durbina.pdf');
        }    
    };
    return module;
})(jQuery);


