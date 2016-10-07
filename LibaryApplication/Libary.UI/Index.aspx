<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Libary.UI.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <link href="BootStrap/Css/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <section class="index-recommends" id="recommends" name="recommends">
                    <div class="page-header index-section-header">
                        <h2>
                            精选安卓电视应用
                            <small>
                                <a target="_blank" href="#"><i class="fa fa-download"></i> 点击下载智能电视必备软件</a>
                                <a class="pull-right" target="_blank" href="#" title="全部应用">全部应用»</a>
                            </small>
                        </h2>
                    </div>
                    <ul class="row list-unstyled index-recommends-list">
                        <li class="col-md-2 col-sm-3 col-xs-6">
                            <div class="thumbnail app-block-element">
                                <a class="app-block-link" href="#" target="_blank">
                                    <img class="app-block-icon" src="" alt="芒果TV" title="芒果TV">
                                    <div class="caption app-block-title">
                                        <h5>芒果TV</h5>
                                    </div>
                                </a>
                                <div class="app-block-over">
                                    <a href="#" target="_blank" >
                                        <span class="app-block-title">芒果TVmangoTV</span>
                                        <span class="app-block-promo">聚合湖南卫视所有综艺节目独家互联网电视版权！</span>
                                        <span class="app-block-rating">
                                            评分：
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                            <i class="fa fa-star"></i>
                                        </span>
                                    </a>
                                    <span class="app-block-detail">
                                        <a href="#" class="btn btn-mini btn-success" target="_blank" title="芒果TV－沙发管家精品应用推荐">详情</a>
                                    </span>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <a class="btn pull-right index-recommends-more" href="#" target="_blank">查看更多应用</a>
                </section>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8 col-sm-12">
                <section class="panel panel-default www-index-section articles">
                    <div class="panel-heading">
                        <h2 class="panel-title">智能电视市场与应用 <small><a class="pull-right" href="#" target="_blank">查看更多&gt;&gt;</a></small></h2>
                    </div>
                    <div class="panel-body">
                        <div class="index-articles-left">
                            <ul class="list-unstyled index-articles-list">
                                <li class="item-model-1">
                                    <a href="#" target="_blank" title="智能电视如何看热播剧《好家伙》"><h3>智能电视如何看热播剧《好家伙》</h3></a>
                                    <div class="item-context">
                                        <img src="#" alt="智能电视如何看热播剧《好家伙》" title="智能电视如何看热播剧《好家伙》">
                                        <div class="item-text">
                                            <p>智能电视如何看热播剧《好家伙》 <a href="#" target="_">[ 详细 ]</a></p>
                                        </div>
                                    </div>
                                </li>
                                <li class="item-model-3">
                                    <span></span>
                                    <a href="#" target="_blank" title="无需会员看高清热门大片！">无需会员看高清热门大片！</a>
                                </li>
                            </ul>
                        </div>
                        <div class="index-articles-right">
                            <ul class="list-unstyled index-articles-list">
                                <li class="item-model-2">
                                    <a href="#" target="_blank">
                                        <div class="item-image">
                                            <img src="##.jpg" alt="一张图看懂小米电视3S" title="一张图看懂小米电视3S">
                                        </div>
                                        <span>一张图看懂小米电视3S</span>
                                    </a>
                                </li>
                                <li class="item-model-2">
                                    <a href="#.jpg" target="_blank">
                                        <div class="item-image">
                                            <img src="./沙发网 - 沙发管家官方下载网站_files/dd360ef1203488c1c3fc53191e1883b7.png" alt="小米电视3s 65英寸首测" title="小米电视3s 65英寸首测">
                                        </div>
                                        <span>小米电视3s 65英寸首测</span>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </section>
            </div>
            <div class="col-md-4 hidden-sm">
                <section class="panel panel-default www-index-section devices-rank">
                    <div class="panel-heading">
                        <h2 class="panel-title">热门设备推荐 <small><a class="pull-right" href="http://www.shafa.com/product" target="_blank">查看更多&gt;&gt;</a></small></h2>
                    </div>
                    <div class="panel-body">
                        <ul class="nav nav-tabs" role="tablist">
                            <li role="presentation" class="active">
                                <a href="http://www.shafa.com/#rank_tv" aria-controls="rank_tv" role="tab" data-toggle="tab">智能电视</a>
                            </li>
                            <li role="presentation">
                                <a href="http://www.shafa.com/#rank_box" aria-controls="rank_box" role="tab" data-toggle="tab">电视盒子</a>
                            </li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane active" id="rank_tv" role="tabpanel">
                                <ul class="list-unstyled devices-rank-list">
                                    <li class="active" data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="#" target="_blank" title="小米电视2 49寸">
                                            <span class="ranking-item-1">1</span>
                                            <h3>小米电视2 49寸</h3>
                                            <span class="rank-item-price">￥4149</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/818786d8c2392414eed408b50306a962.jpg!240x" alt="小米电视2 49寸" title="小米电视2 49寸">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>49英寸, 超高清4K, 硬屏, LED, 四核 Cortex-A9架构 1.45GHz, 2GB DDR3 双通道, 8GB eMMC 高速闪存, MIUI TV, 偏光式3D</p>
                                                <a class="btn btn-primary pull-right" href="#" target="_blank">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="#" target="_blank" title="康佳X80U嫦娥电视">
                                            <span class="ranking-item-2">2</span>
                                            <h3>康佳X80U嫦娥电视</h3>
                                            <span class="rank-item-price">￥6999</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/f10b2eb4e2b4235f73214d691912e1ec.jpg!240x" alt="康佳X80U嫦娥电视" title="康佳X80U嫦娥电视">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>55英寸, 超高清4K, 硬屏, LED, 64位架构芯片, 1GB, 4GB, YIUI易柚5.0, 快门式3D, 逐行扫描, 全方位立体环绕声, 均衡音效 智能音控, 三级能效</p>
                                                <a class="btn btn-primary pull-right" href="#" target="_blank">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="last" data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="#" target="_blank" title="飞利浦PHF5755/T3">

                                            <span>7</span>
                                            <h3>飞利浦PHF5755/T3</h3>
                                            <span class="rank-item-price">￥1499</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/0f293a430ba2934d99ff8a9c3bfd6169.jpg!240x" alt="飞利浦PHF5755/T3" title="飞利浦PHF5755/T3">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>32英寸, 高清720P, 硬屏, 四核 CPU + 双核 GPU + 双核 VPU, 1GB, 4GB, Android  4.4, 逐行扫描, 三级能效</p>
                                                <a class="btn btn-primary pull-right" href="#" target="_blank">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                            <div class="tab-pane " id="rank_box" role="tabpanel">
                                <ul class="list-unstyled devices-rank-list">
                                    <li class="active" data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="#" target="_blank" title="小米盒子1G增强版">

                                            <span class="ranking-item-1">1</span>
                                            <h3>小米盒子1G增强版</h3>
                                            <span class="rank-item-price">￥299</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/94efb8ec1afead645d04043d349cd963.jpg!240x" alt="小米盒子1G增强版" title="小米盒子1G增强版">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>四核 CPU Cortex-A9架构 2.0GHz + 八核 GPU Mali-450MP6 600MHz, 1GB DDR3双通道, 4GB eMMC, Android 4.4, 4K(3840×2160), HDMI接口,CVBS复合视频,AV端子, 支持数字音频输出（SPDIF）, 101*101*19.5mm</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/ycgVbRd1RBmlSuCn.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box1&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="http://www.shafa.com/product/box/ycgVm8AO5rSeGHH4.html" target="_blank" title="小米盒子2G增强版" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box2&#39;);">

                                            <span class="ranking-item-2">2</span>
                                            <h3>小米盒子2G增强版</h3>
                                            <span class="rank-item-price">￥399</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/2a2213a4e7e8ce2cd05b8528fc152fd1.jpg!240x" alt="小米盒子2G增强版" title="小米盒子2G增强版">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>四核 CPU Cortex-A9架构 2.0GHz + 八核 GPU Mali-450MP6, 2GB DDR3双通道, 4GB eMMC高速闪存, Android 4.4, 4K(3840×2160), HDMI接口,CVBS复合视频,AV端子, 支持数字音频输出（SPDIF）, 101*101*19.5mm</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/ycgVm8AO5rSeGHH4.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box2&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="http://www.shafa.com/product/box/ytZvCFW1APbN90Ct.html" target="_blank" title="华为悦盒" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box3&#39;);">

                                            <span class="ranking-item-3">3</span>
                                            <h3>华为悦盒</h3>
                                            <span class="rank-item-price">￥199</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/e431dcacef246847e3023a84ed4f2cb4.jpg!240x" alt="华为悦盒" title="华为悦盒">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>2×1.2 GHz, 6000 DMIPS, 1GB, 4GB, Android 4.2.2, Video decoding up to 1080p@30Hz, 1 × Mini AV interface, 1 × HDMI, 1 × Optical for SPDIF, 25×130×130 mm (0.98 in. × 5.12 in.× 5.12 in.)</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/ytZvCFW1APbN90Ct.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box3&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="http://www.shafa.com/product/box/ycgVbvelA1lfId46.html" target="_blank" title="天猫魔盒2" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box4&#39;);">

                                            <span>4</span>
                                            <h3>天猫魔盒2</h3>
                                            <span class="rank-item-price">￥299</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/54204a66eb9b97858643269febe65f34.jpg!240x" alt="天猫魔盒2" title="天猫魔盒2">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>四核 CPU Cortex-A9r4架构 1.9GHz AML8726-M8四核处理器 + 八核 GPU Mali-450MP6 600MHz, 2GB DDR3, 8GB eMMC, Android - YunOS 2.0, 1080P, HDMI接口, HDMI接口, 118*111*26.8mm, 243.5g</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/ycgVbvelA1lfId46.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box4&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="http://www.shafa.com/product/box/ycgViePiY3G8RAB2.html" target="_blank" title="大麦盒子DM1001" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box5&#39;);">

                                            <span>5</span>
                                            <h3>大麦盒子DM1001</h3>
                                            <span class="rank-item-price">￥318</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/65e674c9e71878e8437d47e4bb9c7280.jpg!240x" alt="大麦盒子DM1001" title="大麦盒子DM1001">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>双核 CPU Cortex-A9架构 1.5GHz, 1GB, 4GB, Android4.2, 1080P, 支持HDMI线接口, 110.45*107.15*30.90mm</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/ycgViePiY3G8RAB2.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box5&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="http://www.shafa.com/product/box/yjzasq4orAp7DjKt.html" target="_blank" title="小米小盒子mini" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box6&#39;);">

                                            <span>6</span>
                                            <h3>小米小盒子mini</h3>
                                            <span class="rank-item-price">￥199</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/eb4d3be988a344747b912cd3aab11c99.jpg!240x" alt="小米小盒子mini" title="小米小盒子mini">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>四核 CPU Cortex-A7 1.3GHz  构架 +四+二核 GPU Mali-450 416MHz, 1GB DDR3, 4GB eMMC 4.5 高速闪存, 安卓4.4.2系统, 1080p(1920×1080), HDMI1.4a x 1, HDMI1.4a x 1, 46.8 x 46.8 x 38mm, 73g</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/yjzasq4orAp7DjKt.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box6&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="last" data-shafa-collapse="accordion">
                                        <a class="rank-item-title" href="http://www.shafa.com/product/box/yc6WTK0malxRfJd0.html" target="_blank" title="华为MediaQ M321" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box7&#39;);">

                                            <span>7</span>
                                            <h3>华为MediaQ M321</h3>
                                            <span class="rank-item-price">￥258</span>
                                        </a>
                                        <div class="rank-item-content">
                                            <div class="rank-item-image">
                                                <img src="./沙发网 - 沙发管家官方下载网站_files/3c4b249c49e8bd0d546258f21be032ba.jpg!240x" alt="华为MediaQ M321" title="华为MediaQ M321">
                                            </div>
                                            <div class="rank-item-text">
                                                <p>四核 CPU, 1GB, 4GB, Android4.4(通过Google CTS认证), 4K，1080p，1080I，720P, HDMI输出  AV复合视频输出接口 &amp; SPDIF输出接口（二合一）, 85mm * 85mm * 15.5mm, 500g</p>
                                                <a class="btn btn-primary pull-right" href="http://www.shafa.com/product/box/yc6WTK0malxRfJd0.html" target="_blank" onclick="ga(&#39;send&#39;, &#39;event&#39;, &#39;shafaProductLibrary&#39;, &#39;click&#39;, &#39;box7&#39;);">查看</a>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <section class="index-hot-devices">
                    <div class="page-header index-section-header">
                        <h2>热门产品安装指南</h2>
                    </div>
                    <div class="row">
                        <div class="col-md-3 col-sm-6">
                            <div class="hot-device-item">
                                <a target="_blank" href="http://www.shafa.com/methods/tianmao_12">
                                    <img class="device-item-img" src="./沙发网 - 沙发管家官方下载网站_files/86f68fd437c2f6220c0d3d308b6f17f60f1a54ca.jpg" alt="天猫魔盒M13" title="天猫魔盒M13">
                                    <h3 class="device-item-title clearfix">天猫魔盒M13<img class="pull-right" src="./沙发网 - 沙发管家官方下载网站_files/402eced6e7186de202097ea329699de15f704222.png" alt=""></h3>
                                </a>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </div>
</asp:Content>
