<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Libary.UI.Account.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <link href="../BootStrap/Css/account.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-4 col-sm-offset-3">
            <section class="well well-lg account-register">
                <label class="account-register-title">注册Libary</label>
                <%--     <form id="register">--%>
                <div class="form-group">
                    <input class="form-control input-sm" placeholder="用户名" name="username" type="text">
                </div>
                <div class="form-group">
                    <input type="text" class="form-control input-sm" placeholder="真实姓名"  name="realname" />
                </div>

                <div class="form-group">
                    <input class="form-control input-sm" placeholder="邮箱" name="email" type="text">
                </div>
                <div class="form-group">
                    <input class="form-control input-sm" placeholder="密码" name="password" type="password" value="">
                </div>
                <div class="form-group">
                    <input class="form-control input-sm" placeholder="确认密码" name="confirm_password" type="password" value="">
                </div>
                <div class="form-group">
                    <input type="text" class="form-control input-sm" placeholder="地址" name="address" />
                </div>
                <div class="form-group">
                    <input type="text" class="form-control input-sm" placeholder="手机" name="phone" />
                </div>
                <div class="form-group">
                    <input type="text" class="form-control input-sm" placeholder="验证码" name="validtycode" />
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        <input class="btn btn-primary btn-block" type="submit" value="注册">
                    </div>
                    <div class="col-sm-3 col-sm-offset-3">
                        <a href="#" class="btn btn-default btn-block">去登录</a>
                    </div>
                </div>
                <%--    </form>--%>
            </section>
        </div>
    </div>
    <script type="text/javascript">
        $(function () {
            $("input[name='username']").blur(function () {
                if ($(this).val().length >= 5)
                {
                    console.log(2);
                    $.post("/ashx/CheckUserName.ashx", { "username": $(this).val() }, function (data) {
                        if (data == "Y") {
                            alert("此用户已存在");
                        } else {
                            alert("此用户可用");
                        }
                    });
                }
            });
        });
    </script>
</asp:Content>

