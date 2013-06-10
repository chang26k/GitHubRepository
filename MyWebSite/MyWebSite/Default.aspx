<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebSite._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Weekly Task</h3>
    <ol class="round">
        <li class="one">
            <h5>Introductory to C#, GitHub and AppHarbor</h5>
            This week lets learn the basics.&nbsp; C#, GitHub and AppHarbor will be the core around our weekly task.&nbsp; <a href="weekly/week1/week1.aspx"> Week  1 Assignment</a></li>
        <li class="two">
            <h5>Loops and OO design</h5>
            More basic concepts.&nbsp; Week 2 Assignment</li>
        <li class="three">
            <h5>Lets write our first API, WebService and WCF</h5>
            API, WebServices and WCF are a must learn.&nbsp; So, lets write some simple examples. <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Week 3 Assignment</a></li>
    </ol>
</asp:Content>
