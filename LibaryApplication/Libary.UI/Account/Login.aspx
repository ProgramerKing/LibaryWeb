<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Libary.UI.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <link href="../BootStrap/Css/account.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
                <section class="well well-lg account-login">
                    <h2 class="account-login-title">登录沙发网</h2>

                    <form method="POST" action="#" accept-charset="UTF-8" class="account-login-form">
                        <input name="_token" type="hidden" value="faKZLC3Cw4agizy6FiELCeuCWX7pYk257Q9KdySB">

                        <div class="form-group">
                            <input class="form-control input-lg" required="required" placeholder="用户名" name="username" type="text">
                        </div>
                        <div class="form-group">
                            <input class="form-control input-lg" required="required" placeholder="密码" name="password" type="password" value="">
                        </div>


                        <div class="row login-form-buttons">
                            <div class="col-sm-3 form-button-login">
                                <input class="btn btn-primary btn-block" type="submit" value="登录">
                            </div>
                            <div class="col-sm-4" style="padding: 1px">
                                <a href="http://account.shafa.com/oauth/authorize?provider=weixin"><img src="./沙发网用户中心login_files/weixin_login_32.png"></a>
                            </div>
                            <div class="col-sm-5 pull-right">
                                <a href="#" class="btn btn-default form-button-forget">忘记密码</a>
                                <a href="#" class="btn btn-default form-button-register">去注册</a>
                            </div>
                        </div>

                    </form>
                </section>
            </div>
        </div>
    </div>
</asp:Content>
