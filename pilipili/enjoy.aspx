<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="enjoy.aspx.vb" Inherits="pilipili.enjoy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </h1>
    <h1>已为您自动推荐</h1>
    <p>国产中字影片，AI分析结果，您一定喜欢</p>
    <iframe src="//player.bilibili.com/player.html?aid=246403365&bvid=BV1rv411s7eP&cid=291649782&page=1" scrolling="no" border="0" frameborder="no" framespacing="0" allowfullscreen="true" style="width: 793px; height: 414px"> </iframe>
    <br />
    <br />
    <br />
    <iframe src="//player.bilibili.com/player.html?aid=543625897&bvid=BV1ji4y1c7sg&cid=283947698&page=1" scrolling="no" border="0" frameborder="no" framespacing="0" allowfullscreen="true" style="width: 790px; height: 383px"> </iframe>
    <br />
    <br />
    <br />
    <iframe src="//player.bilibili.com/player.html?aid=28579550&bvid=BV1ys411u7a3&cid=49476026&page=1" scrolling="no" border="0" frameborder="no" framespacing="0" allowfullscreen="true" id="I1" name="I1" style="width: 798px; height: 353px"> </iframe>
    <br />
    <br />
    <p>
        <asp:Button ID="Button1" runat="server" Text="喜欢，下一个" />
        <asp:Button ID="Button2" runat="server" Text="不喜欢，换一个" />
    </p>
    <p>&nbsp;</p>
</asp:Content>
