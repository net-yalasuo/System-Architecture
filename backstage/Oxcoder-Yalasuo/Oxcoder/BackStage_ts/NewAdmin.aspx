<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAdmin.aspx.cs" Inherits="Oxcoder.BackStage_ts.NewAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <meta name="description" content=""/>
        <meta name="author" content="BootstrapStyler"/>

        <title>oxcoder后台</title>

        
        <!-- Bootstrap core CSS -->
        <link href="bootstrap/css/bootstrap.min.css?v=3.1.1" rel="stylesheet"/>

        <!-- Font Awesome CSS -->
        <link href="fonts/font-awesome/css/font-awesome.min.css?v=4.0.3" rel="stylesheet"/>

        <!-- Bootstrap Switch -->
        <link href="css/libs/bootstrap-switch.min.css?v=3.0.0" rel="stylesheet"/>

        <!-- Bootstrap Select -->
        <link href="css/libs/bootstrap-select.min.css" rel="stylesheet"/>

        <!-- IcoMoon CSS -->
        <link href="fonts/icomoon/style.css?v=1.0" rel="stylesheet"/>

        <!-- morris.js -->
        <link href="css/libs/morris.css" rel="stylesheet"/>

        <!-- Summernote -->
        <link href="css/libs/summernote.css" rel="stylesheet"/>
        <link href="css/libs/summernote-bs3.css" rel="stylesheet"/>

        <!-- Custom styles for this template -->
        <link href="css/styler/style.css" rel="stylesheet" type="text/css"/>

        
        <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
        <!--[if lt IE 9]>
            <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
            <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    

        <div class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand hidden-sm" href="#">OXcoder后台</a>
                </div>
                <div class="navbar-collapse collapse" role="navigation">
                    <ul class="nav navbar-nav navbar-right">
                        <li>
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="text">admin</span></a>
                        </li>
                        <li>
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span class="text">退出</span></a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">

                <div class="col-md-10 col-md-push-2 col-sm-9 col-sm-push-3 col-no-left-padding">
                    <section id="middle">
                        <div class="col-md-4">
                            <form action="#" method="post" class="form-bordered" onsubmit="return false;">
                                <div class="form-group">
                                    <label for="example-nf-email">用户名</label>
                                    <asp:TextBox ID="AdminUserName" runat="server" Width="1000" Height="40"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="example-nf-email">密码</label>
                                    <asp:TextBox ID="AdminPassword" runat="server" Width="1000" Height="40"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="16px"  Width="163px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                    <asp:ListItem Selected="True" Value="super">超级管理员 </asp:ListItem>
                                    <asp:ListItem Value="normal">普通管理员 </asp:ListItem>
                                    </asp:RadioButtonList>

                                </div>
                                <div class="form-group form-actions">
                                    <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="生成" />
                                </div>
                            </form>
                        </div>


                    </section>
                </div><!-- /.col-md-10 -->

                <aside class="col-md-2 col-md-pull-10 col-sm-3 col-sm-pull-9">

                    <div id="sidebar">

                        <div class="panel-group" id="app-menu">
                        
                            <div class="panel panel-default panel-no-padding">
                                <div class="panel-heading">
                                    <h4 class="panel-title">用户管理</h4>
                                </div><!-- /.panel-heading -->
                                <div id="menu-app" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked" id="pages-app">
                                            <li class=""><a href="admin_user_manage.html"><b class="icon-cover"></b><i class="imoon imoon-dashboard fa-fw"></i> 个人用户管理</a></li>
                                            <li class=""><a href="admin_corp_manage.html"><b class="icon-cover"></b><i class="imoon imoon-folder fa-fw"></i> 企业用户管理</a></li>
                                            <li class=""><a href="admin_corp_pass.html"><b class="icon-cover"></b><i class="imoon imoon-drawer3 fa-fw"></i> 企业入驻审批<span class="pull-right badge badge-danger">4</span></a></li>
                                            <li class=""><a href="admin_user_invite.html"><b class="icon-cover"></b><i class="imoon imoon-users fa-fw"></i> 邀请码管理</a></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->
                            </div><!-- /.panel -->

                            <div class="panel panel-default panel-no-padding">
                                <div class="panel-heading">
                                    <h4 class="panel-title">挑战管理</h4>
                                </div><!-- /.panel-heading -->
                                <div id="Div1" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked">
                                            <li class=""><a href="admin_challenge_info.html"><b class="icon-cover"></b><i class="imoon imoon-play fa-fw"></i> 挑战信息管理</a></li>
                                            <li class=""><a href="admin_challenge_upload.html"><b class="icon-cover"></b><i class="imoon imoon-calendar fa-fw"></i> 挑战题目管理</a></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->

                            </div><!-- /.panel -->
                            <div class="panel panel-default panel-no-padding">
                                <div class="panel-heading">
                                    <h4 class="panel-title">练习场管理</h4>
                                </div><!-- /.panel-heading -->
                                <div id="Div2" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked" id="Ul1">
                                            <li class=""><a href="admin_study_upload.html"><b class="icon-cover"></b><i class="imoon imoon-play3 fa-fw"></i> 练习场题目管理</a></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->
                            </div><!-- /.panel -->
                            <div class="panel panel-default panel-no-padding">
                                <div class="panel-heading">
                                    <h4 class="panel-title">收入</h4>
                                </div><!-- /.panel-heading -->
                                <div id="Div3" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked" id="Ul2">
                                            <li class=""><a href="admin_money.html"><b class="icon-cover"></b><i class="imoon imoon-menu2 fa-fw"></i> 收入管理</a></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->
                            </div><!-- /.panel -->
                            <div class="panel panel-default panel-no-padding">
                                <div class="panel-heading">
                                    <h4 class="panel-title">通知</h4>
                                </div><!-- /.panel-heading -->
                                <div id="Div4" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked" id="Ul3">
                                            <li class=""><a href="admin_message.html"><b class="icon-cover"></b><i class="imoon imoon-bubbles fa-fw"></i> 通知管理</a></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->
                            </div><!-- /.panel -->
                            <div class="panel panel-default panel-no-padding">
                                <div class="panel-heading">
                                    <h4 class="panel-title">管理员</h4>
                                </div><!-- /.panel-heading -->
                                <div id="Div5" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked" id="Ul4">
                                            <li class="active"><a href="admin_admin.html"><b class="icon-cover"></b><i class="imoon imoon-cogs fa-fw"></i> 管理员管理</a></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->
                            </div><!-- /.panel -->
                        
                        </div><!-- /.panel-group -->
                        
                    </div><!-- /#sidebar -->  

                </aside>
                
            </div><!-- /.row -->
        </div><!-- /.container -->



        
        <!-- jQuery -->
        <script src="js/libs/jquery-1.11.0.min.js"></script>

        <!-- Bootstrap core JavaScript -->
        <script src="bootstrap/js/bootstrap.min.js?v=3.1.1"></script>

        <!-- Sparkline -->
        <script src="js/libs/jquery.sparkline.min.js"></script>

        <!-- Bootstrap Switch -->
        <script src="js/libs/bootstrap-switch.min.js?v=3.0.0"></script>

        <!-- Bootstrap Select -->
        <script src="js/libs/bootstrap-select.min.js"></script>

        <!-- Bootstrap File -->
        <script src="js/libs/bootstrap-filestyle.js"></script>

        <!-- Raphael JS -->
        <script src="js/libs/raphael-min.js"></script>

        <!-- morris.js -->
        <script src="js/libs/morris.min.js"></script>

        <!-- Summernote -->
        <script src="js/libs/summernote.min.js"></script>

        <!-- Theme script -->
        <script src="js/styl



    </form>
</body>
</html>
