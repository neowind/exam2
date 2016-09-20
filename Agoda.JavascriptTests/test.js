var expect = require('chai').expect;
var ajaxCall = require('../Agoda/Content/Scripts/ajaxCall.js').ajaxCall;

describe("ajaxCall", function () {

    //beforeEach(function(){
    //    var mockTarget = {
    //        result: '',
    //        html: function (compiledHTML) { this.result = compiledHTML },
    //    };
    //});

    it("Test constructor", function () {
        var _ajaxCall = new ajaxCall('requester', 'template', 'target');
        expect(_ajaxCall.requester).to.equal('requester');
    });

    it("Test onSuccess", function () {
        var expectedResult = '<tr><td>c1</td><td>c2</td></tr>';

        var mockData = ['c1', 'c2'];

        var mockTemplate = function (data) {
            var html = '';
            if (data.length > 0) {
                for (var i = 0; i < data.length; i++) {
                    html += ('<td>' + data[i] + '</td>');
                }
                html = '<tr>' + html + '</tr>';
            }
            return html;
        };

        var mockTarget = {
            result: '',
            html: function (compiledHTML) { this.result = compiledHTML },
        };

        var _ajaxCall = new ajaxCall(undefined, mockTemplate, mockTarget);        
        _ajaxCall.onSuccess(mockData)
        expect(mockTarget.result).to.equal(expectedResult);
    });

    it("Test onFail", function () {
        var expectedResult = 'error';

        var mockTarget = {
            result: '',
            html: function (compiledHTML) { this.result = compiledHTML },
        };

        var _ajaxCall = new ajaxCall(undefined, undefined, mockTarget);
        _ajaxCall.onFiled(undefined, 'error');
        expect(mockTarget.result).to.equal(expectedResult);
    });
});