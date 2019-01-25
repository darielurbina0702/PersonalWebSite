var googleHelper = (function ($) {
    "use strict"
    var module = {
        onready: function () {
            $('#tracker').on('click', function () {
                console.log('resume/onClick');
                ga('send', 'pageview',  'resume/onClick');               
            });          
        }    
    };
    return module;
})(jQuery);


