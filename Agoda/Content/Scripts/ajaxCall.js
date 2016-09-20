(function (exports) {
    "use strict";

    function ajaxCall(requester, template, target) {
        this.requester = requester;
        this.template = template;
        this.target = target;
    };
    
    exports.ajaxCall = ajaxCall;

    ajaxCall.prototype.onSuccess = function(data) {
        var theCompiledHtml = this.template(data);
        
        //// Add the compiled html to the page
        this.target.html(theCompiledHtml);
    };
    
    ajaxCall.prototype.onFiled = function (jqXHR, textStatus) {
        this.target.html(textStatus);
    };

    ajaxCall.prototype.requestData = function (uri) {
        this.requester.getJSON(uri)
            .done(this.onSuccess.bind(this))
            .fail(this.onFiled.bind(this));
    };


})(this);



//function onSuccess(template, data) {
//    var theCompiledHtml = template(data);

//    //// Add the compiled html to the page
//    $('.content-placeholder').html(theCompiledHtml);
//};

//function onFiled(jqXHR, textStatus) {
//    $('.content-placeholder').html(textStatus);
//};

//function requestData(requester, template) {
//    requester.getJSON(uri)
//        .done(onSuccess.bind(undefined, template))
//        .fail(onFiled);
//};