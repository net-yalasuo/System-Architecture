<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="Oxcoder.BackStage_ts.PersonalInfo" %>

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
                        <div class="col-md-12">
                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">总注册用户</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->
                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">日活跃用户</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->
                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">周活跃用户</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->
                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">月活跃用户</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->
                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">昨日注册用户</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->


                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">昨日接受挑战次数</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->
                            <div class="col-xs-12 col-sm-6 col-md-3">
                                <div class="stat-block stat-primary">
                                    <div class="icon">
                                        <b class="icon-cover"></b>
                                        <i class="imoon imoon-list"></i>
                                    </div>
                                    <div class="details">
                                        <a href="tasks.html">
                                            <div class="number">1349</div>
                                            <div class="description">昨日做挑战次数</div>
                                        </a>
                                    </div>               
                                </div>
                            </div><!-- /.col-xs-12 -->

                            统计：
                            1. 每周注册用户数走势图
                            2. 每周登录用户数走势图
                            3. 每日接受挑战数量走势图
                            4. 每日做挑战数量走势图
                            5. 用户编程方向统计（接受挑战方向的饼图）
                            6. 用户薪资统计（接受挑战薪资的饼图）
                            7. 绑定各个社交帐号比率的饼图
                        </div>
                        <div class="col-md-12">
                            <p runat="server" id ="resultMsg"></p>
                            <div class="div-myroademap-right-above">
                                <section id="pull-right">
                                    <div style="display:inline-block;vertical-align: top;">
                                        <div class="input-group" style="width:400px;">
                                            <input name="example-input2-group1" class="form-control" placeholder="请输入关键词，姓名、邮箱"/>
                                            <span class="input-group-addon"><i class="fa fa-search"></i></span>
                                        </div>
                                    </div>
                                </section>
								

								<asp:Table ID="personalTable" runat="server" CssClass="table table-hover">                                
                                    <asp:TableRow CssClass="">
                                        <asp:TableCell><b>ID</b></asp:TableCell>
                                        <asp:TableCell><b>姓名</b></asp:TableCell>
                                        <asp:TableCell><b>年龄</b></asp:TableCell>
                                        <asp:TableCell><b>性别</b></asp:TableCell>
                                        <asp:TableCell><b>手机</b></asp:TableCell>
                                        <asp:TableCell><b>邮箱</b></asp:TableCell>
                                        <asp:TableCell><b>身价</b></asp:TableCell>
                                        <asp:TableCell><b>级别</b></asp:TableCell>
                                        <asp:TableCell><b>技术类型</b></asp:TableCell>
                                        <asp:TableCell><b>接受挑战数量</b></asp:TableCell>
                                        <asp:TableCell><b>绑定社交帐号</b></asp:TableCell>
                                        <asp:TableCell><b>更新时间</b></asp:TableCell>
                                        <asp:TableCell><b>操作</b></asp:TableCell>
                                    </asp:TableRow>

                                    <asp:TableRow CssClass="">
                                        <asp:TableCell><b>206</b></asp:TableCell>
                                        <asp:TableCell><b>asdf</b></asp:TableCell>
                                        <asp:TableCell><b>20</b></asp:TableCell>
                                        <asp:TableCell><b>男</b></asp:TableCell>
                                        <asp:TableCell><b>15818177261</b></asp:TableCell>
                                        <asp:TableCell><b>337501728@qq.com</b></asp:TableCell>
                                        <asp:TableCell><b>8765</b></asp:TableCell>
                                        <asp:TableCell><b>3</b></asp:TableCell>
                                        <asp:TableCell><b>java</b></asp:TableCell>
                                        <asp:TableCell><b>9</b></asp:TableCell>
                                        <asp:TableCell><b>weibo，github，stackoverflow</b></asp:TableCell>
                                        <asp:TableCell><b>2014-09-26 01:35:30</b></asp:TableCell>
                                        <asp:TableCell><b>
                                            <a href="#" class="btn btn-small btn-danger" type="button">屏蔽</a>
                                            <a href="#" class="btn btn-small btn-primary" type="button">详情（数据统计）</a>
                                        </b></asp:TableCell>
                                    </asp:TableRow>
				                </asp:Table>



                                <section id="Section1">                    
                                    <ul class="pagination pull-right">
                                        <li><a href="#">«</a></li>
                                        <li><a href="#">1</a></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">4</a></li>
                                        <li><a href="#">5</a></li>
                                    <li><a href="#">»</a></li>
                                    </ul>
                                </section>
                            </div>
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
                                            <li class="active"><a href="admin_user_manage.html"><b class="icon-cover"></b><i class="imoon imoon-dashboard fa-fw"></i> 个人用户管理</a></li>
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
                                            <li class=""><a href="admin_admin.html"><b class="icon-cover"></b><i class="imoon imoon-cogs fa-fw"></i> 管理员管理</a></li>
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
        <script src="js/styler/script.js"></script>




    </form>
</body>
</html>
