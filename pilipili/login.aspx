<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.vb" Inherits="pilipili.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <asp:Panel ID="Panel2" runat="server">
        <p>
            用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            密码&nbsp;&nbsp; ：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Visible="False">1</asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="没有账号，注册一个" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="提交" Enabled="False" />
        </p>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        中文名：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        出生地 ：<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="美洲"></asp:ListItem>
            <asp:ListItem Value="非洲"></asp:ListItem>
            <asp:ListItem Value="欧洲"></asp:ListItem>
            <asp:ListItem Value="大洋洲"></asp:ListItem>
            <asp:ListItem Value="南极洲"></asp:ListItem>
            <asp:ListItem>亚洲</asp:ListItem>
        </asp:DropDownList>
        <br />
        年龄&nbsp;&nbsp;&nbsp; ：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        邮箱&nbsp;&nbsp;&nbsp; ：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="发送验证码" Width="85px" />
        <br />
        验证码 ：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        填写完成请点击提交<br /> 确保你是男性</asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible="False">
        请如实选择<br /> 
        <asp:Image ID="Image1" runat="server" Height="167px" ImageUrl="./imge/1.jpg" Width="285px" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="喜欢" />
        <asp:Button ID="Button5" runat="server" Text="不喜欢" />
        <br /> 
        已经选择<asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
        /15<br />
        为了确保你是男人，请上传那里的照片<br /> 
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="开始" />
        <br />
        <br />
        照片来自于<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://cn.pornhub.com/categories">网络</asp:HyperLink>
        侵权请<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://github.com/GreenPowerDragon/free-AV">联系</asp:HyperLink>
    </asp:Panel>
</asp:Content>
