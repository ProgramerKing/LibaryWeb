<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Libary.UI.Account.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <link href="../BootStrap/Css/account.css" rel="stylesheet" />
    <link href="../BootStrap/Css/bootstrapValidator.min.css" rel="stylesheet" />
    <script src="../BootStrap/JS/bootstrapValidator.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-6 col-sm-offset-3">
            <section class="well well-lg account-register">
                <h2 class="account-register-title">注册Libary</h2>
                    <div class="form-group">
                        <input class="form-control input-lg" required="required" placeholder="用户名" name="username" type="text"><lable id="userNameMsg"></lable>
                    </div>
                    <div class="form-group">
                        <input class="form-control input-lg" required="required" placeholder="邮箱" name="email" type="text">
                    </div>
                    <div class="form-group">
                        <input class="form-control input-lg" required="required" placeholder="密码" name="password" type="password" value="">
                    </div>
                    <div class="form-group">
                        <input class="form-control input-lg" required="required" placeholder="确认密码" name="confirm_password" type="password" value="">
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            <input class="btn btn-primary btn-block" type="submit" value="注册">
                        </div>
                        <div class="col-sm-3 col-sm-offset-3">
                            <a href="http://account.shafa.com/login" class="btn btn-default btn-block">去登录</a>
                        </div>
                    </div>
            </section>
        </div>
    </div>
    <script src="../Js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#username").blur(function () {
                if ($(this).val() != "") {
                    var reg = /^[a-zA-Z0-9_\u4e00-\u9fa5]{4,20}$/;
                    if (reg.test($(this).val())) {
                        $.post("/ashx/CheckUserName.ashx", { "userName": $(this).val() }, function (data) {
                            if(data=="Y")
                            {
                                $("#userNameMsg").text("用户名已存在！");
                            }
                            else
                            {
                                $("#userNameMsg").text("此用户名可用！");
                            }
                        });
                    }
                    else {
                        $("#userNameMsg").text("提示信息");
                    }
                } else {
                    $("#userNameMsg").text("用户名不能为空！");
                }
            });
        });
    </script>
</asp:Content>
