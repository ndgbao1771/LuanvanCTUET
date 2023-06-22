var loginControl = function() {
    this.initialize = function () {
        registerEvents();
    }

    var registerEvents = function () {
        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            var user = $('#txtUserName').val();
            var password = $('#txtPassword').val();
            login(user, password);
        })
    }
    var login = function (user, pass) {
        var token = $('form').find("input[name='__RequestVerificationToken']").val();
        $.ajax({
            url: '/admin/login/authen',
            method: "POST",
            data: {
                UserName: user,
                Password : pass
            },
            dataType: 'json',
            success: function (res) {
                if (res.success) {
                    window.location.href = "/Admin/Home/Index";
                }
                else {
                    all.notify('Đăng nhập không đúng', 'error');
                }
            }
        })
    }
}