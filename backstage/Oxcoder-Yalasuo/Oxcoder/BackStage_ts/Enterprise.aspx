<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enterprise.aspx.cs" Inherits="Oxcoder.BackStage_ts.Enterprise" %>

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


     <script type="text/javascript" language="javascript">
         //得到焦点时触发事件
         function onFocusFun(element, elementValue) {
             if (element.value == elementValue) {
                 element.value = "";
                 element.style.color = "";
             }

         }
         //离开输入框时触发事件
         function onblurFun(element, elementValue) {

             if (element.value == '') {
                 element.style.color = "#808080";
                 element.value = elementValue;
             }

         }
         </script>

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
                            <p runat="server" id ="resultMsg"></p>
                            <div class="div-myroademap-right-above">
                                <section id="pull-right">
                                    <div style="display:inline-block;vertical-align: top;">
                                        <div class="input-group" style="width:400px;">
                                            <asp:TextBox ID="TextName" runat="server" Width="350px" Height="30" text="请输入关键词，公司名"
                                                OnFocus="onFocusFun(this,'请输入关键词，公司名')" 
                                                OnBlur="onblurFun(this,'请输入关键词，公司名')" ></asp:TextBox>
                                            <asp:Button ID="Button1" runat="server" class="btn-default" OnClick="Button1_Click" Text="搜索"/>
                                            
                                        </div>
                                    </div>
                                </section>


                                <asp:Table ID="adminTable" runat="server" CssClass="table table-hover">                                
                                    <asp:TableRow CssClass="">
                                        <asp:TableCell><b>ID</b></asp:TableCell>
                                        <asp:TableCell><b>公司名</b></asp:TableCell>
                                        <asp:TableCell><b>Emaiil</b></asp:TableCell>
                                        <asp:TableCell><b>工作地点</b></asp:TableCell>
                                        <asp:TableCell><b>时间</b></asp:TableCell>
                                        <asp:TableCell><b>操作</b></asp:TableCell>
                                    </asp:TableRow>

                                    <asp:TableRow CssClass="" Visible="false">
                                        <asp:TableCell><b>18</b></asp:TableCell>
                                        <asp:TableCell><b>北京稀松平常公司</b></asp:TableCell>
                                        <asp:TableCell><b>skdjf@qq.com</b></asp:TableCell>
                                        <asp:TableCell><b>北京</b></asp:TableCell>
                                        <asp:TableCell><b>2014-09-23 15:05:32</b></asp:TableCell>
                                        <asp:TableCell><b>
                                            <a href="admin_corp_pass_info.html" class="btn btn-info" data-toggle="modal" data-target="#myModal">详情</a>
                                            
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
                                            
                                            <li class=""><asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl ="~/BackStage_ts/PersonalInfo.aspx"><b class="icon-cover"></b><i class="imoon imoon-dashboard fa-fw"></i>个人用户管理</asp:HyperLink></li>                    
                                            <li class=""><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-folder fa-fw"></i>企业用户管理</asp:HyperLink></li>
                                            <li class=""><asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl ="~/BackStage_ts/Enterprise.aspx"><b class="icon-cover"></b><i class="imoon imoon-drawer3 fa-fw"></i>企业入驻审批</asp:HyperLink></li>
                                            <li class=""><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-users fa-fw"></i>邀请码管理</asp:HyperLink></li>
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
                                            <li class=""><asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-play fa-fw"></i>挑战信息管理</asp:HyperLink></li>
                                            <li class=""><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-calendar fa-fw"></i>挑战题目管理</asp:HyperLink></li>
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
                                            <li class=""><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-play3 fa-fw"></i>练习场题目管理</asp:HyperLink></li>
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
                                            <li class=""><asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-menu2 fa-fw"></i>收入管理</asp:HyperLink></li>
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
                                            <li class=""><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl ="~/BackStage_ts/Hahaha.aspx"><b class="icon-cover"></b><i class="imoon imoon-bubbles fa-fw"></i>通知管理</asp:HyperLink></li>
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
                                            <li class=""><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl ="~/BackStage_ts/Administrator.aspx"><b class="icon-cover"></b><i class="imoon imoon-cogs fa-fw"></i>管理员管理</asp:HyperLink></li>
                                        </ul>
                                    </div><!-- /.panel-body -->
                                </div><!-- /.panel-collapse -->
                            </div><!-- /.panel -->
                        
                        </div><!-- /.panel-group -->
                        
                    </div><!-- /#sidebar -->  

                </aside>
                
            </div><!-- /.row -->
        </div><!-- /.container -->

        
<!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
        <h4 class="modal-title" id="myModalLabel">审批</h4>
      </div>
      <div class="modal-body">
        <div class="form-group">
                <p><label for="example-nf-email">企业全称</label></p>
                <p><asp:Label ID="nameLabel" runat="server" Text="qwe公司"></asp:Label></p>
                
            </div>
            <div class="form-group">
                <p><label for="example-nf-email">注册邮箱</label></p>
                <p><asp:Label ID="emailLabel" runat="server" Text="qwe@163.com"></asp:Label></p>
            </div>
            <div class="form-group">
                <p><label for="example-nf-email">企业营业执照</label></p>
                <img src="img/beedo.jpg" style="max-height:500px;max-width:500px;">
            </div>
            <div class="form-group">
                <p><label for="example-nf-email">招聘负责人联系方式</label></p>
                <p><asp:Label ID="phoneLabel" runat="server" Text="15100117911"></asp:Label></p>
            </div>
            <div class="form-group form-actions">                
                <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="通过" />
                <asp:Button ID="Button3" class="btn" runat="server" OnClick="Button3_Click" Text="拒绝" />
            </div>
      </div>
    </div>
  </div>
</div>



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
