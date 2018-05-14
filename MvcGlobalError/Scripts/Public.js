//ajax请求全局设置
$.ajaxSetup({
    //异步请求
    async: true,
    //缓存设置
    cache: false
});

$(document).ajaxComplete(function (evt, request, settings) {
    var text = request.responseText;
    if (text) {
        try {
            //Unauthorized  登录超时或者无权限
            if (request.status == "401") {
                var json = $.parseJSON(text);
                if (json.Message == "logout") {
                    //登录超时,弹出系统登录框
                } else {
                    layer.alert(json.ExceptionMessage ? json.ExceptionMessage : "系统异常，请联系系统管理员", {
                        title: "错误提醒",
                        icon: 2
                    });
                }
            } else if (request.status == "500") {
                var json = $.parseJSON(text);
                $.ajax({
                    type: "post",
                    url: "/Error/Path500",
                    data: { "": json },
                    data: json,
                    dataType: "html",
                    success: function (data) {
                        //页面层
                        layer.open({
                            title: '异常信息',
                            type: 1,
                            shade: 0.8,
                            shift: -1,
                            area: ['100%', '100%'],
                            content: data,
                        });
                    }
                });

            }
        } catch (e) {
            console.log(e);
        }
    }
});