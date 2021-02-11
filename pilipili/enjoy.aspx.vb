Public Class enjoy
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Cookies("login") Is Nothing Then
            Response.Write("<Script Language=JavaScript>window.location.href='./login.aspx';</Script>")
        Else
            Me.Label1.Text = Request.Cookies("login").Value
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Write("<Script Language=JavaScript>alert('孩子，该醒醒了，你想做一辈子的萎哥吗？');</Script>")
        Response.Write("<Script Language=JavaScript>alert('拿起的是枪棒，失去的是精华，得到的是秒男');</Script>")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("<Script Language=JavaScript>alert('孩子，我佩服你的觉悟，祝你戒撸成功！');</Script>")
    End Sub
End Class