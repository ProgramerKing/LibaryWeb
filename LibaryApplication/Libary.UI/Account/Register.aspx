<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Libary.UI.Account.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <link href="../BootStrap/Css/account.css" rel="stylesheet" />

    <script src="../BootStrap/JS/bootstrapValidator.min.js"></script>
    <link href="../BootStrap/Css/bootstrapValidator.min.css" rel="stylesheet" />
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
                        <input class="form-control input-sm" placeholder="邮箱" name="email" type="text">
                    </div>
                    <div class="form-group">
                        <input class="form-control input-sm" placeholder="密码" name="password" type="password" value="">
                    </div>
                    <div class="form-group">
                        <input class="form-control input-sm" placeholder="确认密码" name="confirm_password" type="password" value="">
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
            //$("#form1").bootstrapValidator();
            $('#form1').bootstrapValidator({
                message: 'This value is not valid',
                //feedbackIcons: {
                //    valid: 'glyphicon glyphicon-ok',
                //    invalid: 'glyphicon glyphicon-remove',
                //    validating: 'glyphicon glyphicon-refresh'
                //},
                fields: {
                    username: {
                        message: '用户名验证失败',
                        validators: {
                            notEmpty: {
                                message: '用户名不能为空'
                            },
                            stringLength: {
                                min: 6,
                                max: 18,
                                message: '用户名长度必须在6到18位之间'
                            },
                            regexp: {
                                regexp: /^[a-zA-Z0-9_]+$/,
                                message: '用户名只能包含大写、小写、数字和下划线'
                            }
                        }
                    },
                    email: {
                        validators: {
                            notEmpty: {
                                message: '邮箱地址不能为空'
                            },
                            emailAddress: {
                                message:'邮箱地址格式有误'
                            }
                        }
                    },
                    password: {
                        validators: {
                            notEmpty: {
                                message: '密码不能为空'
                            }
                        }
                    },
                    confirm_password: {
                        validators: {
                            notEmpty: {
                                message: '确认密码不能为空'
                            }
                        }
                    }
                }
            });
        });
    </script>
</asp:Content>

