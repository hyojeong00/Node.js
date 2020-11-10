<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="prac3.homepage" MasterPageFile="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <title>WMSS-Welding Management SPC System</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--헤더--%>
        <header>
            <div class="container-fluid">
                    <div class="row">
                        <div class="intro-text col-lg-12 text-center">
                            <div>
                                <div id="welcome">Welding Monitoring SPC System</div>
                                <div class="intro-heading">용접모니터링 시스템</div>
                                <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-large" /> <%--여기에 로그인페이지 연결--%>
                            </div>
                        </div>
                </div>
            </div>
        </header>

     <!--문의, 연락-->
        <section id="contact">
            <%--<div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="section-title">
                            <h2>Contact Us</h2>
                            <p>문의사항이 있으면 편하게 연락주세요</p>
                        </div>
                    </div>
                </div>
            </div>--%>
            <div class="container-fluid">
                <div class="row text-center">
                    <div class="fa-columns">
                        <h3>위치</h3>
                        <p>
                            부산광역시 사상구 모라동
                            <br>
                            벤처타워 811
                        </p>
                        <p><i class="fa fa-phone"></i>010-3432-4378</p>
                        <p><i class="fa fa-envelope"></i>hj_kim94@daum.net</p>
                    </div>
                    <div class="fa-columns">
                        <div class="section-title">
                            <h2>Contact Us</h2>
                            <p>문의사항이 있으면 편하게 연락주세요</p>
                        </div>
                    </div>

                    <div class="fa-columns">
                        <h3>운영시간</h3>
                        <p><i class="fa fa-clock-o"></i><span class="day">Weekdays : </span><span>9am to 6pm</span></p>
                        <p><i class="fa fa-clock-o"></i><span class="day">Saturday : </span><span>9am to 1pm</span></p>
                        <p><i class="fa fa-clock-o"></i><span class="day">Sunday : </span><span>Closed</span></p>
                    </div>
                </div>

                <%--<div class="col-md-6">
                        <form name="sentMessage" id="contactForm" novalidate="">

                            <%--<div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="text" class="form-control"
                                            placeholder="이름을 입력하세요 *"
                                            id="name" required=""
                                            date-validation-required-message="이름을 입력하세요">
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>

                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="email" class="form-control"
                                            placeholder="연락처를 입력하세요 *"
                                            id="email" required=""
                                            data-validation-required-message="연락처를 입력하세요">
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                            </div>--%>

                <%--<div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <textarea class="form-control"
                                            placeholder="메세지를 입력하세요 *" id="message"
                                            required=""
                                            data-validation-required-message="메세지를 입력하세요"></textarea>
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12 text-center">
                                    <div id="success"></div>
                                    <button type="submit" class="btn">메세지 보내기</button>
                                </div>
                            </div>
                        </form>
                    </div>--%>
            </div>

        </section>
</asp:Content>